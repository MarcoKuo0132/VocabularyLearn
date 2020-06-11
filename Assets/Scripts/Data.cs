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

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "across",
                Vocabulary_tw = "橫越",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "across from",
                Extension_tw = "在...對面"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "act",
                Vocabulary_tw = "行動(V.)",
                Sentence_en = null,
                Synonyms = "do",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "action",
                Vocabulary_tw = "行動(n.)",
                Sentence_en = "Actions speak louder than words",
                Sentence_tw = "坐而言不如起而行",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "actor/actress",
                Vocabulary_tw = "演員",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "add",
                Vocabulary_tw = "增加",
                Sentence_en = null,
                Synonyms = null,
                Antonym = "remove",
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "address",
                Vocabulary_tw = "地址",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "adult",
                Vocabulary_tw = "成人",
                Sentence_en = null,
                Synonyms = "grown-up",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "afraid",
                Vocabulary_tw = "害怕的",
                Sentence_en = "I am afraid of rats.",
                Sentence_tw = "我怕老鼠",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "after",
                Vocabulary_tw = "在...之後",
                Sentence_en = null,
                Synonyms = null,
                Antonym = "before",
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "afternoon",
                Vocabulary_tw = "下午",
                Sentence_en = "We usually take a walk in the afternoon.",
                Sentence_tw = "我們時常在午後散步",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "again",
                Vocabulary_tw = "再次",
                Sentence_en = "Do it again.",
                Sentence_tw = "再做一次",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "against",
                Vocabulary_tw = "逆著",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "go against",
                Extension_tw = "違背"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "age",
                Vocabulary_tw = "年齡",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "come of age",
                Extension_tw = "到達法定年齡"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "ago",
                Vocabulary_tw = "以前",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "agree",
                Vocabulary_tw = "同意(V.)",
                Sentence_en = null,
                Synonyms = null,
                Antonym = "disagree",
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "agreement",
                Vocabulary_tw = "同意(N.)",
                Sentence_en = null,
                Synonyms = "consent",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "ahead",
                Vocabulary_tw = "在前方",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "ahead of",
                Extension_tw = "在...之前"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "air",
                Vocabulary_tw = "空氣",
                Sentence_en = "Let's go out and have some fresh air.",
                Sentence_tw = "讓我們去外面呼吸新鮮空氣",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "airmail",
                Vocabulary_tw = "航空郵件",
                Sentence_en = null,
                Synonyms = null,
                Antonym = "surface mail",
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "airplane/plane",
                Vocabulary_tw = "飛機",
                Sentence_en = null,
                Synonyms = "aircraft",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "airport",
                Vocabulary_tw = "機場",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "airport tax",
                Extension_tw = "機場稅"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "all",
                Vocabulary_tw = "所有的",
                Sentence_en = "All computers here have broken down.",
                Sentence_tw = "這裡所有電腦都當機了",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "allow",
                Vocabulary_tw = "允許",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "almost",
                Vocabulary_tw = "幾乎",
                Sentence_en = null,
                Synonyms = "nearly",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "alone",
                Vocabulary_tw = "單獨的",
                Sentence_en = "Leave me alone.",
                Sentence_tw = "別打擾我",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );
    }
}
