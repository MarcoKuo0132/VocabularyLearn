using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject VocabularyInput;
    public GameObject SentenceInput;
    public GameObject SynonymsInput;
    public GameObject AntonymInput;
    public GameObject ExtensionInput;

    public GameObject VocabularyText;
    public GameObject SentenceText;
    public GameObject SynonymsText;
    public GameObject AntonymText;
    public GameObject ExtensionText;

    Data data;

    enum appState
    {
        wait,
        input,
        waitForInput,
        check
    };
    appState state;
    int count;

    bool isPass;

    // Start is called before the first frame update
    void Start()
    {
        data = new Data();
        data.setVocabularysArray();

        state = appState.wait;
        count = 0;
        isPass = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case appState.wait:
                break;
            case appState.input:
                SetText();
                break;
            case appState.waitForInput:
                break;
            case appState.check:
                Check();
                break;
        }
    }

    public void PressStart()
    {
        state = appState.input;
    }

    public void PressSubmit()
    {
        state = appState.check;
    }

    void SetText()
    {
        if (data.VocabularysList[count].Vocabulary_en != null)
        {
            VocabularyText.GetComponent<Text>().text = data.VocabularysList[count].Vocabulary_tw;
        }

        if (data.VocabularysList[count].Sentence_en != null)
        {
            SentenceText.GetComponent<Text>().text = data.VocabularysList[count].Sentence_tw;
        }

        if (data.VocabularysList[count].Synonyms != null)
        {
            SynonymsText.GetComponent<Text>().text = data.VocabularysList[count].Vocabulary_tw;
        }

        if (data.VocabularysList[count].Antonym != null)
        {
            AntonymText.GetComponent<Text>().text = "有反義字";
        }

        if (data.VocabularysList[count].Extension_en != null)
        {
            ExtensionText.GetComponent<Text>().text = data.VocabularysList[count].Extension_tw;
        }

        state = appState.waitForInput;
    }

    void Check()
    {
        if (data.VocabularysList[count].Vocabulary_en != null)
        {
            if (VocabularyInput.GetComponent<InputField>().text != (data.VocabularysList[count].Vocabulary_en))
            {
                Wrong();
                return;
            }
        }

        if (data.VocabularysList[count].Sentence_en != null)
        {
            if (SentenceInput.GetComponent<InputField>().text != (data.VocabularysList[count].Sentence_en))
            {
                Wrong();
                return;
            }
        }

        if (data.VocabularysList[count].Synonyms != null)
        {
            if (SynonymsInput.GetComponent<InputField>().text != (data.VocabularysList[count].Synonyms))
            {
                Wrong();
                return;
            }
        }

        if (data.VocabularysList[count].Antonym != null)
        {
            if (AntonymInput.GetComponent<InputField>().text != (data.VocabularysList[count].Antonym))
            {
                Wrong();
                return;
            }
        }

        if (data.VocabularysList[count].Extension_en != null)
        {
            if (ExtensionInput.GetComponent<InputField>().text != (data.VocabularysList[count].Extension_en))
            {
                Wrong();
                return;
            }
        }

        Pass();
    }

    void Wrong()
    {
        CleanAllInput();
        state = appState.waitForInput;
    }

    void Pass()
    {
        CleanAllInput();
        CleanAllText();
        count++;
        state = appState.input;
    }

    void CleanAllInput()
    {
        VocabularyInput.GetComponent<InputField>().text = "";
        SentenceInput.GetComponent<InputField>().text = "";
        SynonymsInput.GetComponent<InputField>().text = "";
        AntonymInput.GetComponent<InputField>().text = "";
        ExtensionInput.GetComponent<InputField>().text = "";
    }

    void CleanAllText()
    {
        VocabularyText.GetComponent<Text>().text = "";
        SentenceText.GetComponent<Text>().text = "";
        SynonymsText.GetComponent<Text>().text = "";
        AntonymText.GetComponent<Text>().text = "";
        ExtensionText.GetComponent<Text>().text = "";
    }
}
