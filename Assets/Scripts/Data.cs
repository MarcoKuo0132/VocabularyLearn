using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public struct VocabularyBase
    {
        public string Vocabulary_en;   //英文單字
        public string Vocabulary_tw;   //中文意思
        public string Sentence_en;     //英文句子
        public string Sentence_tw;     //中文意思
        public string Synonyms;     //同義字
        public string Antonym;      //反義字
        public string Extension_en;    //英文延伸字
        public string Extension_tw;    //中文意思
    }

    public List<VocabularyBase> VocabularysList;

    public void setVocabularysArray()
    {
        VocabularysList = new List<VocabularyBase>();

        VocabularysList.Add( new VocabularyBase 
            { 
                Vocabulary_en = "a/an",
                Vocabulary_tw = "一個",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = null 
            }
        );

        VocabularysList.Add( new VocabularyBase
            {
                Vocabulary_en = "able",
                Vocabulary_tw = "能夠的",
                Sentence_en = "Nobody is able to finish the math test.",
                Sentence_tw = "沒人能夠完成這次數學考試。",
                Synonyms = "be able to",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add( new VocabularyBase
            {
                Vocabulary_en = "about",
                Vocabulary_tw = "關於",
                Sentence_en = null,
                Synonyms = "concerning",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add( new VocabularyBase
            {
                Vocabulary_en = "above",
                Vocabulary_tw = "在...之上",
                Sentence_en = "A pigeon is flying above the house.",
                Sentence_tw = "一隻鴿子正在房子上面飛。",
                Synonyms = "concerning",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add( new VocabularyBase
            {
                Vocabulary_en = "according to",
                Vocabulary_tw = "根據",
                Sentence_en = null,
                Synonyms = "on the basis of",
                Antonym = null,
                Extension_en = null
            }
        );
    }
}
