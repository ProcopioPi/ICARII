using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace MasterHound
{
    public class FileManager
    {
        public static string projectFolder;             // Name of the project
        public static bool IsProjectStarted = false;    // If it is already saved
               
        public static void SaveQueryIDs(string file, List<string> ids)
        {
            string fileName = @projectFolder + "/" + file;
            if (File.Exists(file)) // adding
            {
                string[] lines;
                List<string> text;
                HashSet<string> uniqueQueries;

                lines           = File.ReadAllLines(file);
                text            = new List<string>(lines);

                text.AddRange(ids);

                uniqueQueries   = new HashSet<string>(text);
                text            = new List<string>(uniqueQueries);

                File.WriteAllLines(fileName, text.ToArray());
            }

            File.WriteAllLines(fileName, ids.ToArray());// first time
        }

        public static void SaveQuery(string line)
        {
            string file = @projectFolder + "/" + K.QUERIES_FILE;
            if (File.Exists(file))
            {
                string[] lines;
                List<string> text;
                HashSet<string> uniqueQueries;

                lines           = File.ReadAllLines(file);
                text            = new List<string>(lines);
                text.Add(line);
                uniqueQueries   = new HashSet<string>(text);
                text            = new List<string>(uniqueQueries);

                File.WriteAllLines(file, text.ToArray());
            }
            else
                File.WriteAllText(file, line);
        }

        public static string[] ReadQueryLines()
        {
            string file = @projectFolder + "/" + K.QUERIES_FILE;
            string[] lines;

            if (File.Exists(file))
            {
                lines = File.ReadAllLines(file);
            }
            else
                lines = new string[0];

            return lines;
        }
        
        public static void SaveAbstract(ArticleInfo article)
        {
            File.WriteAllText(@projectFolder + "/_" + article.ID + K.EXTENSION, article.ToString());
        }

        public static void SaveAbstracts(ArticleInfo[] articles)
        {
            for (int f = 0; f < articles.Length; f++)
            {
                SaveAbstract(articles[f]);
            }
        }

        private static void CreateProjectFolder(string pathString)
        {
            projectFolder = pathString;
            Directory.CreateDirectory(pathString);
        }
        
        public static ArticleInfo OpenFile(string id)
        {
            ArticleInfo tmp;
            string[] lines;

            lines = File.ReadAllLines(id);
            tmp   = new ArticleInfo(lines[(int)FILE_LINES.ID], lines[(int)FILE_LINES.TITLE], lines[(int)FILE_LINES.DATE],
                    lines[(int)FILE_LINES.JOURNAL], lines[(int)FILE_LINES.ABSTRACT], lines[(int)FILE_LINES.STATUS],
                    lines[(int)FILE_LINES.AI_SCORE], lines[(int)FILE_LINES.HUMAN_SCORE], lines[(int)FILE_LINES.DOI],
                    lines[(int)FILE_LINES.CHECKED]);

            return tmp;
        }

        public static string StartProject()
        {
            if (projectFolder == null)
                projectFolder = "PROJECT NAME";//string.Format("{0:yyyy-MM-dd_hh-mm-ss-fffff-tt}", DateTime.Now);

            if(!Directory.Exists(projectFolder))
                CreateProjectFolder(projectFolder);

            IsProjectStarted = true;

            return projectFolder;
        }
                        
        public static void ChangeProjectFolderName(string name)
        {
            DirectoryInfo directoryInfo;

            directoryInfo = new DirectoryInfo(projectFolder);
            if (directoryInfo == null)
            {
                throw new ArgumentNullException("di", "Directory info cannot be NULL");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("New name cannot be NULL or blank", "name");
            }

            projectFolder = name;
            directoryInfo.MoveTo(Path.Combine(directoryInfo.Parent.FullName, name));

            return; // Done
        }
    }
}
