using CommentDetector.Json;
using HLE.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CommentDetector
{
    public class CommentDetector
    {
        public List<string> CsFiles { get; } = new();
        public List<FoundComment> Comments { get; } = new();
        private static readonly Regex regex = new(@"^\s*//", RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        public CommentDetector()
        {
            GetCsFiles(JsonController.Settings.Path);
        }

        private void GetCsFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            CsFiles.AddRange(files.ExceptWhere(f => f.Contains("\\obj\\") || f.Contains("\\Properties\\")).Where(f => f.EndsWith(".cs")));
            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {
                GetCsFiles(dir);
            }
        }

        public void GetComments()
        {
            foreach (string s in CsFiles)
            {
                List<string> allLines = File.ReadAllLines(s).ToList();
                string[] commentLines = allLines.Where(f => regex.IsMatch(f) || f.Contains("*/") || f.Contains("/*")).ToArray();
                foreach (string f in commentLines)
                {
                    Comments.Add(new(s, allLines.IndexOf(f) + 1));
                }
            }
        }

        public void SendComments()
        {
            if(Comments.Any())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (FoundComment s in Comments)
                {
                    Console.WriteLine($"Path: {s.FoundPath} || Line: {s.FoundLine}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No comments has been found!");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

}
