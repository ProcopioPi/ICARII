using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterHound.Naive
{
    public class Document
    {

        public string raw;
        HashSet<string> unique;
        public List<string> words;
        public List<string> completeWords;
        public int id, total;
        public float classification;
        public Dictionary<string, float> vector;// for the final classifications

        public Document(int id, List<string> words, float classification)
        {
            this.id = id;
            this.words = words;
            this.classification = classification;
            ComputeStats();
        }

        public Document(int id, string[] words, float classification)
        {
            this.words = new List<string>(words);
            this.classification = classification;
            ComputeStats();
        }

        public Document(string raw, float classification)
        {
            this.raw = raw;
            this.classification = classification;
            SplitRaw();            
            ComputeStats();
        }

        private void SplitRaw()
        {
            words = new List<string>(raw.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
        }
        
        private void ComputeStats()
        {
            unique = new HashSet<string>(words);
            vector = new Dictionary<string, float>();

            for (int i = 0; i < words.Count; i++) // count ocurrrences
                if (!vector.ContainsKey(words[i]))
                    vector.Add(words[i], 1);
                else
                    vector[words[i]]++;

            total           = words.Count;
            completeWords   = new List<string>(words);//---------------------------MAYBE
            words           = new List<string>(unique);// remove repetitions   
        }

        public Document(string str, string[] bag, float classification)
        {
            string[] strs;

            this.classification = classification;
            total = 0;
            // cycles to delete the stopwords
            str = str.Replace("\r\n", " "); // delete stop words
            str = str.Replace(".", " ");    // delete stop words
            strs = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            vector = new Dictionary<string, float>();

            for (int b = 0; b < bag.Length; b++)
                vector.Add(bag[b], 0);

            for (int w = 0; w < strs.Length; w++)
            {
                if (vector.ContainsKey(strs[w]))
                {
                    vector[strs[w]]++;
                    total++;
                }
            }
        }

        public void CleanStopWords(string[] stopWords)
        {
            string[] strs;

            vector = new Dictionary<string, float>();

            for (int s = 0; s < stopWords.Length; s++)// eliminate stop-words
                raw = raw.Replace(stopWords[s], " ");

            strs = raw.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);//split the words

            unique = new HashSet<string>(strs); //find unique words without the stop-words
            words = new List<string>(unique);

            for (int w = 0; w < strs.Length; w++)// count repetitions
            {
                if (vector.ContainsKey(strs[w]))
                {
                    vector[strs[w]]++;
                    total++;
                }
                else
                    vector.Add(strs[w], 1);
            } //*/
        }

        public override string ToString()
        {
            return total + " : " + vector.Count;
        }
    }
}
