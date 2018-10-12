using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syn.WordNet;
using System.IO;

namespace EduSearchIS
{
    class WordNet
    {
        public const string WordNet_DIR = @"C:\Users\svege\Dropbox\Master sem 4\IR\Assignment\dict";
        public static WordNetEngine InitializeWordNetEngine()
        {
            WordNetEngine wordNet = new WordNetEngine();

            wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_DIR, "data.adj")), PartOfSpeech.Adjective);
            wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_DIR, "data.adv")), PartOfSpeech.Adverb);
            wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_DIR, "data.noun")), PartOfSpeech.Noun);
            wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_DIR, "data.verb")), PartOfSpeech.Verb);

            wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_DIR, "index.adj")), PartOfSpeech.Adjective);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_DIR, "index.adv")), PartOfSpeech.Adverb);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_DIR, "index.noun")), PartOfSpeech.Noun);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_DIR, "index.verb")), PartOfSpeech.Verb);

            Console.WriteLine("Loading WordNet database....");
            wordNet.Load();
            Console.WriteLine("WordNet Loaded.");


            return wordNet;
        }
    }
}
