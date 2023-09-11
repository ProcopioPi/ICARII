using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterHound.Naive
{
    // 1.- create object Bayes
    // 2.- add each document (should be already clean)*//-------------------------******
    // 3.- call ComputeWordProbabilities() ... CLASSIFY DOCUMENT ...
    public class Bayes
    {
        float countPos, countNeg;
        public float totalProbPositive, totalProbNegative, totalWeightPos, totalWeightNeg;

        public int pos, neg;
        public List<Document> docs;

        public List<string> StopWords;

        public HashSet<string> unique;  // to avoid repetition
        public List<string> BagOfWords; // for ease of iteration

        public Dictionary<string, double> wordPosProb, wordNegProb;

        public Bayes()
        {
            StopWords = new List<string>(Properties.Resources.STOPW.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToArray());

            docs = new List<Document>();
            ResetVariables();
        }

        public void ResetVariables()
        {
            unique = new HashSet<string>();

            wordPosProb = new Dictionary<string, double>();
            wordNegProb = new Dictionary<string, double>();

            totalProbPositive = 0;
            totalProbNegative = 0;

            totalWeightPos = 0;
            totalWeightNeg = 0;

            countPos = 0;
            countNeg = 0;
        }

        public void AddDocument(Document doc)
        {
            docs.Add(doc);
        }

        private void ProcessDoc(Document doc)
        {
            if (doc.classification == -1)//negative
            {
                countNeg++;
                totalWeightNeg += doc.total;
            }

            if (doc.classification == 1)//positive
            {
                countPos++;
                totalWeightPos += doc.total;
            }

            for (int w = 0; w < doc.words.Count; w++)// iterate over every word of document
            {
                if (!unique.Contains(doc.words[w]))
                    unique.Add(doc.words[w]);

                if (doc.classification == 1)//POSITIVE
                {
                    if (wordPosProb.ContainsKey(doc.words[w]))
                        wordPosProb[doc.words[w]] += doc.vector[doc.words[w]];
                    else
                        wordPosProb.Add(doc.words[w], doc.vector[doc.words[w]]);
                }
                else
                    if (wordNegProb.ContainsKey(doc.words[w]))
                        wordNegProb[doc.words[w]] += doc.vector[doc.words[w]];
                    else
                        wordNegProb.Add(doc.words[w], doc.vector[doc.words[w]]);
            }

            totalProbPositive = countPos / docs.Count;
            totalProbNegative = countNeg / docs.Count;          
        }

        private void TrainDocs()
        {
            for (int d = 0; d < docs.Count; d++)
                ProcessDoc(docs[d]);
        }

        public void FillBagOfWords(Document doc)
        {
            for (int w = 0; w < doc.words.Count; w++)// iterate over every word of document
            {
                if (!unique.Contains(doc.words[w]))
                    unique.Add(doc.words[w]);
            }
            BagOfWords = new List<string>(unique);
        }

        public void ComputeWordProbabilities()
        {
            if (BagOfWords == null)
                return;

            string key;
            double exp;
            
            TrainDocs();
            
            exp = 10;
            for (int w = 0; w < BagOfWords.Count; w++)
            {
                key = BagOfWords[w];

                if (wordNegProb.ContainsKey(key))
                    wordNegProb[key] = exp * (wordNegProb[key] + 1) / (BagOfWords.Count + totalWeightNeg);
                else
                    wordNegProb.Add(key, (1f / (BagOfWords.Count + totalWeightNeg)));

                if (wordPosProb.ContainsKey(key))
                    wordPosProb[key] = exp * (wordPosProb[key] + 1) / (BagOfWords.Count + totalWeightPos);
                else
                    wordPosProb.Add(key, (1f / (BagOfWords.Count + totalWeightPos)));
            }
        }

        // we trim the classification only for positive ranking
        public double ClassifyDocument(Document doc)
        {
            double value, pos, neg;
            string key;

            value = 0;
            pos = neg = 1;
            
            for (int s = 0; s < doc.completeWords.Count; s++)
            {
                key = doc.completeWords[s];

                pos *= Sigmoid(wordPosProb[key] )*10;
                neg *= Sigmoid(wordNegProb[key] )*10;
            }
           
            if (totalProbPositive != 1 && totalProbPositive != 0)
                pos *= Sigmoid(totalProbPositive);

            if (totalProbNegative != 1 && totalProbNegative != 0)
                neg *= Sigmoid(totalProbNegative);//*/
            
            pos = Math.Log10(pos);
            neg = Math.Log10(neg);

            value = pos;            
            
            if (neg > pos)
            {
                if (neg > 0)
                    neg *= -1;
                value = neg;
            }
            
           return value;
        }

        public double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
    }
}
