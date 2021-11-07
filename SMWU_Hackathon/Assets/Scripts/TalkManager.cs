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
    {   //프롤로그 눈송대사 
        talkData.Add(100,new string[]{"오늘은 입학키트 받는날!:3", "이제 나도 숙명인이 되는건가봐..너무 기대된다!:3","아이템 '입학키트'를 획득했다!:0", "우와 이게 입학키트! 어디 한번 입학키트를 언박싱해볼까?:0", "눈송이 인형이야! 대박 너무 귀엽다.:1", "우와 뱃지도 주는구나? 한 번 착용해볼까?:2", "어라? 근데 왜 갑자기 어지럽지?:2" });

        //chap1-1
        talkData.Add(200, new string[] { "아니..여긴 어디죠?:0","영화 세트장인가요?:0", "너는 이 아침부터 왜이리 소란이냐... 따라오거라:1" });

        //chap1-2
        talkData.Add(300, new string[] {"눈송아 전국적으로 많은 사립학교들이 설립되고 있지만:1", "남성들 위주로 교육을 받을 수 있는 이 현실이 참으로 슬프지 않느냐?:1", "외국에서 온 선교사들이 여성들을 가르치고 있다고는 하지만....:1", "우리가 우리 힘으로 교육시키지 못하고 있는데 다 무슨 소용이 있겠느냐.:1", "이를 어쩌면 좋을까...:1",
        "흠....:1", "그래. :1","내가 먼저 교육의 장을 설립하여:1","우리의 힘으로,:1","여성의 힘으로, :1","여성들을 교육시키는 학교를 설립해보자!:1","(완전 멋있으시다...여성 교육에 대해 매우 이리 열정적이시다니...):0","....:2","그대들은 듣거라. :1",
        "강화군의 토지, 전답, 임야, 부천의 토지, 자하골에 있는 터 모든 것을 팔아서:1","여학교를 설립해라.:1","무엇하러 내탕금을 여자 교육에 쓰십니까...(웅성웅성) :3","모두 정숙을 유지하거라.:1","여성 교육은 무엇보다 중요하고 힘써야하는 것이니라. :1",
        "많은 여성들은 과거에도 지금도 교육을 받고 있지 못하고 있다.:1","교육은 진리와 지혜의 근원이니라.:1","진명여학교라 짓고 부인회 발회식을 거행하여라.:1","이는 외국의 자본에 의존함 없이,:1","오직 우리 힘으로 일으킨 민족 여성 교육의 효시이니라.:1",
        "눈송아 너가 이 교지를 들고 각계 부인들을 모으거라.:1","할 수 있겠느냐?:1","물론이죠!:0","아이템 '교지'를 획득했다!:4","미션! 가장 왼쪽에 있는 부인에게 교지를 전달하세요!:4"});

        //chap1-3
        talkData.Add(400, new string[] { "여기 교지입니다!:1","고마워요.:0"});

        //chap2 
        talkData.Add(500, new string[] { "독립 만세! 독립 만세!:1", "어...이건?:0", "너 왜 머리를 꺼내놓고 있니?:1","이러다 잡혀 죽을려면 어쩔려고:1", "잡힌다고?:0", "그래.:1", "일본 순사한테 안 잡히려면 댕기를 귀밑까지 땋아 묶어야지.:1", "이거 받아.:1", "자주색 갑사댕기야. 빨리 묶어.:1",
        "그..그래 고마워!:0","(태극기를 흔들며) 독립 만세!!:1","친구야... 학교에서 공부하고 있는게 더 안전하지 않겠어?:0","왜놈 교사한테 차별당하며 공부할 바엔 학교 안다니는게 낫지.:1","우리 숙명여고보 학생들은 동맹 휴학을 하기로 했어.:1",
        "조선인 교사 채용, :1","학생 대우 개선,:1","일본인 교사의 사퇴 등:1","우리의 요구 조건을 들어줄 때까지 우리는 학교 안나갈거야.:1","그러다가 끌려가면 어떡하려고 그래...:0","학교 졸업한 선배님들도 발벗고 나서는데 당연히 나서야지 않겠어?:1",
        "우리의 뜻은 확고해.:1","우린 조선인이니까. 우리나라를 지켜야돼.:1","자. 태극기야.:1","같이 독립을 외쳐보지 않을래?:1"});

        //chap2-1
        talkData.Add(550, new string[] {"대한 독립 만세!!:0","대한 독립 만세!!:1","헉..순사다! 얼른 도망치자!:1","그래!:0","아..또 눈 앞이 깜깜해진다..:0"});

        //chap3-1
        talkData.Add(600, new string[] { "포...폭탄 소리??:0", "이번엔 어딘거지...?:0", "여긴 무슨 시대인거야??:0",
        "학생! 거긴 위험하니까 이쪽으로 와!!:1"});

        //chap3-2
        talkData.Add(650, new string[] { "여긴 안전하니까 친구들이랑 같이 있으렴.:1", "괜찮니?:1", "밖이 많이 소란스럽지...? :1", "전쟁이 빨리 끝나야 할텐데... 휴...:1", "(설마 지금... 6.25 전쟁인가...?):0",
        "우리가 지금 있는 곳은 숙명여자대학 임시 가교사야. :1","가교사? 가교사가 뭔데요?:0","가교사는 임시로 쓰는 학교 건물을 의미해.:1","원래 서울에 학교가 있었는데..:1","지금 서울이 수복되어서 부산에 임시로 세운거란다.:1",
        "우리가 있는 곳이 부산이구나...:0","그렇단다. :1"," 전쟁이 나서 피난을 가야했지만..:1","우리 숙명여자대학의 역사와 교육이 사라지면 안되기 때문에:1", "이곳에서 교육을 하고 있단다.:1",
        " (이런 난리통 속에서도 교육을 하시고 학생들을 돕다니... 감동이야 ㅠ):0","자. 너가 공부할 책이란다.:1","아이템 '책'을 획득했다!:2","감사합니다!:0","아 또또 어지럽네..:0","도대체 언제까지 이럴건데!!:0"});

        //ending
        talkData.Add(700, new string[] { "어? 여긴...:0", "집으로 돌아왔어...:0", "돌아왔다구!!!!ㅠㅠㅠ:0","...:1", "덕분에 오랜 역사를 함께 해온 숙명인의 역할과 공로를 알 수 있었어.:0",
        "주체적인 여성 교육에 앞장 선 순헌황귀비의 열정을:0","항일운동의 본보기가 되었던 숙명여고보 학생들의 숙명 항일 맹휴 사건을:0","혼란스러운 6.25 전쟁 시절에도 학생들의 교육을 책임지던 정신을 가슴에 새기며:0",
        "나도 멋진 숙명인의 길을 걷기 위해 노력할거야:0","타오르는 불꽃은 아니더라도:0","부드럽고 천천히:0","세상을 바꿔보는 눈송이가 되어볼게.:0"});


        portraitData.Add(100 + 0, portraitArr[0]); //입학키트박스 
        portraitData.Add(100 + 1, portraitArr[1]); //눈송인형
        portraitData.Add(100 + 2, portraitArr[2]); //눈송뱃지 
        portraitData.Add(100 + 3, portraitArr[3]); //눈송초상화 

        //챕1 
        portraitData.Add(200 + 0, portraitArr[4]); //눈송초상화
        portraitData.Add(200 + 1, portraitArr[5]); //순헌황귀비 
        portraitData.Add(200 + 2, portraitArr[6]); //기타
       
 

        //챕1-2
        portraitData.Add(300 + 0, portraitArr[7]); //눈송초상화
        portraitData.Add(300 + 1, portraitArr[8]); //순헌황귀비
        portraitData.Add(300 + 2, portraitArr[9]); //기타
        portraitData.Add(300 + 3, portraitArr[10]); //대신들 
        portraitData.Add(300 + 4, portraitArr[11]);//교지 아이템 

        //챕1-3
        portraitData.Add(400 + 0, portraitArr[12]); //부인3 
        portraitData.Add(400 + 1, portraitArr[13]); //눈송초상화 

        //챕1-4
        portraitData.Add(500 + 0, portraitArr[14]); //눈송초상화
        portraitData.Add(500 + 1, portraitArr[15]); //친구 

        //챕2-1
        portraitData.Add(550 + 0, portraitArr[16]); //눈송초상화 
        portraitData.Add(550 + 1, portraitArr[17]); //친구 

        //챕3
        portraitData.Add(600 + 0, portraitArr[18]);//눈송초상화
        portraitData.Add(600 + 1, portraitArr[19]);//교사 
        portraitData.Add(600 + 2, portraitArr[20]);//기타 

        //챕3-2
        portraitData.Add(650 + 0, portraitArr[21]); //눈송
        portraitData.Add(650 + 1, portraitArr[22]);//교사
        portraitData.Add(650 + 2, portraitArr[23]);//책 

        //엔딩
        portraitData.Add(700 + 0, portraitArr[24]);//눈송 
        portraitData.Add(700 + 1, portraitArr[25]);//눈송뱃지 

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
