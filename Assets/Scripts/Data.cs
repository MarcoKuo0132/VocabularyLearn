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

        //6
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

        //11
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

        //16
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

        //21
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

        //26
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

        //31
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "along",
                Vocabulary_tw = "沿著",
                Sentence_en = null,
                Synonyms = "by the side of",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "already",
                Vocabulary_tw = "已經",
                Sentence_en = "I have already done my report.",
                Sentence_tw = "我的報告做完了。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "also",
                Vocabulary_tw = "也",
                Sentence_en = "He is also a teacher.",
                Sentence_tw = "他也是個老師。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "always",
                Vocabulary_tw = "總是",
                Sentence_en = null,
                Synonyms = null,
                Antonym = "never",
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "am",
                Vocabulary_tw = "(用於第一人稱單數)是",
                Sentence_en = "I am a hard-working student.",
                Sentence_tw = "我是個用功的學生。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        //36
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "among",
                Vocabulary_tw = "在...之中",
                Sentence_en = "Among those students, Tim is the smartest one.",
                Sentence_tw = "在這些學生中，提姆是最聰明的。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "and",
                Vocabulary_tw = "和;以及",
                Sentence_en = null,
                Synonyms = "as well as",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "anger",
                Vocabulary_tw = "生氣",
                Sentence_en = null,
                Synonyms = "rage",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "angry",
                Vocabulary_tw = "生氣的",
                Sentence_en = "Mom was angry at me because I didn't go to school.",
                Sentence_tw = "媽媽很生氣因為我沒去上學。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "animal",
                Vocabulary_tw = "動物",
                Sentence_en = null,
                Synonyms = "creature",
                Antonym = null,
                Extension_en = null
            }
        );

        //41
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "another",
                Vocabulary_tw = "另一個的",
                Sentence_en = "This spoon is dirty. Give me another one.",
                Sentence_tw = "這湯匙髒了。給我另外一個。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "answer",
                Vocabulary_tw = "回答",
                Sentence_en = "Can you answer the phone for me?",
                Sentence_tw = "能幫我接個電話嗎?",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "ant",
                Vocabulary_tw = "螞蟻",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "have ants in one's pants",
                Extension_tw = "坐立難安"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "any",
                Vocabulary_tw = "任何的",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "in any way",
                Extension_tw = "無論如何"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "anything",
                Vocabulary_tw = "任何事",
                Sentence_en = "I will do anything for you.",
                Sentence_tw = "我會為你做任何事",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        //46
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "ape",
                Vocabulary_tw = "猿猴",
                Sentence_en = null,
                Synonyms = "primate",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "appear",
                Vocabulary_tw = "出現",
                Sentence_en = null,
                Synonyms = null,
                Antonym = "vanish",
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "apple",
                Vocabulary_tw = "蘋果",
                Sentence_en = "An apple a day keeps the doctor away.",
                Sentence_tw = "一天一蘋果，醫生遠離我",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "April",
                Vocabulary_tw = "四月",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "April Fools' Day",
                Extension_tw = "愚人節"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "are",
                Vocabulary_tw = "(用於第二人稱單數、複數)是",
                Sentence_en = "We are family.",
                Sentence_tw = "我們是一家人",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        //51
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "area",
                Vocabulary_tw = "區域",
                Sentence_en = null,
                Synonyms = "region",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "arm",
                Vocabulary_tw = "手臂",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "arm in arm",
                Extension_tw = "臂挽臂地"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "army",
                Vocabulary_tw = "軍隊",
                Sentence_en = null,
                Synonyms = "troop",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "around",
                Vocabulary_tw = "在...四周",
                Sentence_en = "The convenience store is open around the clock.",
                Sentence_tw = "便利商店營業二十四小時",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "art",
                Vocabulary_tw = "藝術",
                Sentence_en = null,
                Synonyms = "craft",
                Antonym = null,
                Extension_en = null
            }
        );

        //56
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "as",
                Vocabulary_tw = "和...一樣",
                Sentence_en = null,
                Synonyms = "like",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "ask",
                Vocabulary_tw = "問",
                Sentence_en = "Can I ask you a question, Amy?",
                Sentence_tw = "艾咪，我能問妳一個問題嗎?",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "at",
                Vocabulary_tw = "在",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "at night",
                Extension_tw = "在晚上"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "August",
                Vocabulary_tw = "八月",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "in August",
                Extension_tw = "在八月"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "aunt/auntie",
                Vocabulary_tw = "姑姑;阿姨",
                Sentence_en = null,
                Synonyms = null,
                Antonym = "uncle",
                Extension_en = null
            }
        );

        //61
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "autumn",
                Vocabulary_tw = "秋天",
                Sentence_en = "Leaves turn yellow in autumn.",
                Sentence_tw = "樹葉在秋天變黃了。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "away",
                Vocabulary_tw = "離開",
                Sentence_en = "The balloon flew away.",
                Sentence_tw = "氣球飛走了。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "baby",
                Vocabulary_tw = "嬰兒",
                Sentence_en = null,
                Synonyms = "infant",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "back",
                Vocabulary_tw = "背部",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "behind someone's back",
                Extension_tw = "在某人背後"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bad",
                Vocabulary_tw = "壞的",
                Sentence_en = "The mile on the table went bad.",
                Sentence_tw = "桌上的牛奶壞了。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null,
            }
        );

        //66
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bag",
                Vocabulary_tw = "袋子",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "let the cat out of the bag",
                Extension_tw = "洩密"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "ball",
                Vocabulary_tw = "球",
                Sentence_en = null,
                Synonyms = "globe",
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "balloon",
                Vocabulary_tw = "氣球",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "hot-air balloon",
                Extension_tw = "熱氣球"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "banana",
                Vocabulary_tw = "香蕉",
                Sentence_en = "Dad bought a brunch of bananas from the market.",
                Sentence_tw = "爸爸從市場買了一串香蕉。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "band",
                Vocabulary_tw = "樂團",
                Sentence_en = null,
                Synonyms = "group",
                Antonym = null,
                Extension_en = null,
            }
        );

        //71
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bank",
                Vocabulary_tw = "銀行",
                Sentence_en = "Jeff is a teller in a bank.",
                Sentence_tw = "傑夫是銀行行員",
                Synonyms = null,
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bar",
                Vocabulary_tw = "條狀物",
                Sentence_en = null,
                Synonyms = "rod",
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "barber",
                Vocabulary_tw = "理髮師",
                Sentence_en = "I go to barber shop every three week.",
                Sentence_tw = "我每三個禮拜去一次理髮廳。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "base",
                Vocabulary_tw = "基礎",
                Sentence_en = "Vocabulary is the base of a language.",
                Sentence_tw = "單字是一個語言的基礎",
                Synonyms = null,
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "baseball",
                Vocabulary_tw = "棒球",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "baseball cap",
                Extension_tw = "棒球帽"
            }
        );

        //76
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "basic",
                Vocabulary_tw = "基礎的",
                Sentence_en = null,
                Synonyms = "primary",
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "basket",
                Vocabulary_tw = "籃子",
                Sentence_en = "Don't put all your eggs in one basket.",
                Sentence_tw = "別把雞蛋放在同一個籃子裡",
                Synonyms = null,
                Antonym = null,
                Extension_en = null,
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "basketball",
                Vocabulary_tw = "籃球",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "basketball team",
                Extension_tw = "籃球隊"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bat",
                Vocabulary_tw = "蝙蝠",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "blind as a bat",
                Extension_tw = "有眼無珠"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bath",
                Vocabulary_tw = "浴缸;洗澡",
                Sentence_en = "My family had a hot spring bath yesterday.",
                Synonyms = "我的家人昨天去泡溫泉",
                Antonym = null,
                Extension_en = null
            }
        );

        //81
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bathe",
                Vocabulary_tw = "沐浴",
                Sentence_en = null,
                Synonyms = "take a bath",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bathroom",
                Vocabulary_tw = "浴室",
                Sentence_en = null,
                Synonyms = null,
                Antonym = null,
                Extension_en = "go to the bathroom",
                Extension_tw = "上廁所"
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "be",
                Vocabulary_tw = "是",
                Sentence_en = "Tony wants to be an architect.",
                Sentence_tw = "湯尼想當個建築師。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "beach",
                Vocabulary_tw = "海灘",
                Sentence_en = "More and more young people like to play beach volleyball.",
                Sentence_tw = "越來越多人喜歡打沙灘排球。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "bear",
                Vocabulary_tw = "熊",
                Sentence_en = "Mom gave me a bear hug as soon as she saw me.",
                Sentence_tw = "媽媽看到我時，給了我一個深深地擁抱。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        //86
        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "beat",
                Vocabulary_tw = "打",
                Sentence_en = null,
                Synonyms = "hit",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "beautiful",
                Vocabulary_tw = "美麗的",
                Sentence_en = null,
                Synonyms = "attractive",
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "beatuty",
                Vocabulary_tw = "美人",
                Sentence_en = "Have you ever seen the movie, Beauty and the Beast?",
                Sentence_tw = "你有看過電影'美女與野獸'嗎?",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "because",
                Vocabulary_tw = "因為",
                Sentence_en = "Jenny was late today because she overslept this morning.",
                Sentence_tw = "珍妮今天遲到了，因為她早上睡過頭。",
                Synonyms = null,
                Antonym = null,
                Extension_en = null
            }
        );

        VocabularysList.Add(new VocabularyBase
            {
                Vocabulary_en = "become",
                Vocabulary_tw = "成為",
                Sentence_en = null,
                Synonyms = "turn into",
                Antonym = null,
                Extension_en = null
            }
        );

        //91
    }
}
