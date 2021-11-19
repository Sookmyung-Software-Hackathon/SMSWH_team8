using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr; 

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {   //���ѷα� ���۴�� 
        talkData.Add(100,new string[]{"������ ����ŰƮ �޴³�!:3", "���� ���� �������� �Ǵ°ǰ���..�ʹ� ���ȴ�!:3","������ '����ŰƮ'�� ȹ���ߴ�!:0", "��� �̰� ����ŰƮ! ��� �ѹ� ����ŰƮ�� ��ڽ��غ���?:0", "������ �����̾�! ��� �ʹ� �Ϳ���.:1", "��� ������ �ִ±���? �� �� �����غ���?:2", "���? �ٵ� �� ���ڱ� ��������?:2" });

        //chap1-1
        talkData.Add(200, new string[] { "�ƴ�..���� �����?:0","��ȭ ��Ʈ���ΰ���?:0", "�ʴ� �� ��ħ���� ���̸� �Ҷ��̳�... ������Ŷ�:1" });

        //chap1-2
        talkData.Add(300, new string[] {"���۾� ���������� ���� �縳�б����� �����ǰ� ������:1", "������ ���ַ� ������ ���� �� �ִ� �� ������ ������ ������ �ʴ���?:1", "�ܱ����� �� ��������� �������� ����ġ�� �ִٰ��� ������....:1", "�츮�� �츮 ������ ������Ű�� ���ϰ� �ִµ� �� ���� �ҿ��� �ְڴ���.:1", "�̸� ��¼�� ������...:1",
        "��....:1", "�׷�. :1","���� ���� ������ ���� �����Ͽ�:1","�츮�� ������,:1","������ ������, :1","�������� ������Ű�� �б��� �����غ���!:1","(���� �������ô�...���� ������ ���� �ſ� �̸� �������̽ôٴ�...):0","....:2","�״���� ��Ŷ�. :1",
        "��ȭ���� ����, ����, �Ӿ�, ��õ�� ����, ���ϰ� �ִ� �� ��� ���� �ȾƼ�:1","���б��� �����ض�.:1","�����Ϸ� �������� ���� ������ ���ʴϱ�...(��������) :3","��� ������ �����ϰŶ�.:1","���� ������ �������� �߿��ϰ� ������ϴ� ���̴϶�. :1",
        "���� �������� ���ſ��� ���ݵ� ������ �ް� ���� ���ϰ� �ִ�.:1","������ ������ ������ �ٿ��̴϶�.:1","�������б��� ���� ����ȸ ��ȸ���� �����Ͽ���.:1","�̴� �ܱ��� �ں��� ������ ����,:1","���� �츮 ������ ����Ų ���� ���� ������ ȿ���̴϶�.:1",
        "���۾� �ʰ� �� ������ ��� ���� ���ε��� �����Ŷ�.:1","�� �� �ְڴ���?:1","��������!:0","������ '����'�� ȹ���ߴ�!:4","�̼�! ���� ���ʿ� �ִ� ���ο��� ������ �����ϼ���!:4"});

        //chap1-3
        talkData.Add(400, new string[] { "���� �����Դϴ�!:1","��������.:0"});

        //chap2 
        talkData.Add(500, new string[] { "���� ����! ���� ����!:1", "��...�̰�?:0", "�� �� �Ӹ��� �������� �ִ�?:1","�̷��� ���� �������� ��¿����:1", "�����ٰ�?:0", "�׷�.:1", "�Ϻ� �������� �� �������� ��⸦ �͹ر��� ���� �������.:1", "�̰� �޾�.:1", "���ֻ� �������. ���� ����.:1",
        "��..�׷� ������!:0","(�±ر⸦ ����) ���� ����!!:1","ģ����... �б����� �����ϰ� �ִ°� �� �������� �ʰھ�?:0","�ֳ� �������� �������ϸ� ������ �ٿ� �б� �ȴٴϴ°� ����.:1","�츮 ���������� �л����� ���� ������ �ϱ�� �߾�.:1",
        "������ ���� ä��, :1","�л� ��� ����,:1","�Ϻ��� ������ ���� ��:1","�츮�� �䱸 ������ ����� ������ �츮�� �б� �ȳ����ž�.:1","�׷��ٰ� �������� ��Ϸ��� �׷�...:0","�б� ������ ����Ե鵵 �߹��� �����µ� �翬�� �������� �ʰھ�?:1",
        "�츮�� ���� Ȯ����.:1","�츰 �������̴ϱ�. �츮���� ���Ѿߵ�.:1","��. �±ر��.:1","���� ������ ���ĺ��� ������?:1"});

        //chap2-1
        talkData.Add(550, new string[] {"���� ���� ����!!:0","���� ���� ����!!:1","��..�����! �� ����ġ��!:1","�׷�!:0","��..�� �� ���� ����������..:0"});

        //chap3-1
        talkData.Add(600, new string[] { "��...��ź �Ҹ�??:0", "�̹��� ������...?:0", "���� ���� �ô��ΰž�??:0",
        "�л�! �ű� �����ϴϱ� �������� ��!!:1"});

        //chap3-2
        talkData.Add(650, new string[] { "���� �����ϴϱ� ģ�����̶� ���� ������.:1", "������?:1", "���� ���� �Ҷ�������...? :1", "������ ���� ������ ���ٵ�... ��...:1", "(���� ����... 6.25 �����ΰ�...?):0",
        "�츮�� ���� �ִ� ���� �������ڴ��� �ӽ� �������. :1","������? �����簡 ������?:0","������� �ӽ÷� ���� �б� �ǹ��� �ǹ���.:1","���� ���￡ �б��� �־��µ�..:1","���� ������ �����Ǿ �λ꿡 �ӽ÷� ����Ŷ���.:1",
        "�츮�� �ִ� ���� �λ��̱���...:0","�׷��ܴ�. :1"," ������ ���� �ǳ��� ����������..:1","�츮 �������ڴ����� ����� ������ ������� �ȵǱ� ������:1", "�̰����� ������ �ϰ� �ִܴ�.:1",
        " (�̷� ������ �ӿ����� ������ �Ͻð� �л����� ���ٴ�... �����̾� ��):0","��. �ʰ� ������ å�̶���.:1","������ 'å'�� ȹ���ߴ�!:2","�����մϴ�!:0","�� �Ƕ� ��������..:0","����ü �������� �̷��ǵ�!!:0"});

        //ending
        talkData.Add(700, new string[] { "��? ����...:0", "������ ���ƿԾ�...:0", "���ƿԴٱ�!!!!�ФФ�:0","...:1", "���п� ���� ���縦 �Բ� �ؿ� �������� ���Ұ� ���θ� �� �� �־���.:0",
        "��ü���� ���� ������ ���� �� ����Ȳ�ͺ��� ������:0","���Ͽ�� �����Ⱑ �Ǿ��� ���������� �л����� ���� ���� ���� �����:0","ȥ�������� 6.25 ���� �������� �л����� ������ å������ ������ ������ �����:0",
        "���� ���� �������� ���� �ȱ� ���� ����Ұž�:0","Ÿ������ �Ҳ��� �ƴϴ���:0","�ε巴�� õõ��:0","������ �ٲ㺸�� �����̰� �Ǿ��.:0"});


        portraitData.Add(100 + 0, portraitArr[0]); //����ŰƮ�ڽ� 
        portraitData.Add(100 + 1, portraitArr[1]); //��������
        portraitData.Add(100 + 2, portraitArr[2]); //���۹��� 
        portraitData.Add(100 + 3, portraitArr[3]); //�����ʻ�ȭ 

        //é1 
        portraitData.Add(200 + 0, portraitArr[4]); //�����ʻ�ȭ
        portraitData.Add(200 + 1, portraitArr[5]); //����Ȳ�ͺ� 
        portraitData.Add(200 + 2, portraitArr[6]); //��Ÿ
       
 

        //é1-2
        portraitData.Add(300 + 0, portraitArr[7]); //�����ʻ�ȭ
        portraitData.Add(300 + 1, portraitArr[8]); //����Ȳ�ͺ�
        portraitData.Add(300 + 2, portraitArr[9]); //��Ÿ
        portraitData.Add(300 + 3, portraitArr[10]); //��ŵ� 
        portraitData.Add(300 + 4, portraitArr[11]);//���� ������ 

        //é1-3
        portraitData.Add(400 + 0, portraitArr[12]); //����3 
        portraitData.Add(400 + 1, portraitArr[13]); //�����ʻ�ȭ 

        //é1-4
        portraitData.Add(500 + 0, portraitArr[14]); //�����ʻ�ȭ
        portraitData.Add(500 + 1, portraitArr[15]); //ģ�� 

        //é2-1
        portraitData.Add(550 + 0, portraitArr[16]); //�����ʻ�ȭ 
        portraitData.Add(550 + 1, portraitArr[17]); //ģ�� 

        //é3
        portraitData.Add(600 + 0, portraitArr[18]);//�����ʻ�ȭ
        portraitData.Add(600 + 1, portraitArr[19]);//���� 
        portraitData.Add(600 + 2, portraitArr[20]);//��Ÿ 

        //é3-2
        portraitData.Add(650 + 0, portraitArr[21]); //����
        portraitData.Add(650 + 1, portraitArr[22]);//����
        portraitData.Add(650 + 2, portraitArr[23]);//å 

        //����
        portraitData.Add(700 + 0, portraitArr[24]);//���� 
        portraitData.Add(700 + 1, portraitArr[25]);//���۹��� 

    }

    public string GetTalk (int id,int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
        {
            return null;
        }
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id,int portraitIndex)
    {
        return portraitData[id + portraitIndex]; 
    }
}
