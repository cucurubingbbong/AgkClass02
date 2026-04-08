using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryPractice : MonoBehaviour
{
    // 왼쪽이 키고 , 오른쪽이 값입니다
    // 키와 값의 자료형엔 제한이 없습니다
    public Dictionary<string , int> library = new Dictionary<string , int>();

    void Start()
    {
        // 딕셔너리 값 추가 (딕셔너리 이름.Add(키 , 값))
        library.Add("해리포터", 3);
        library.Add("라오루", 5);
        library.Add("어린왕자", 2);

        // 딕셔너리 값 변경 ( 딕셔너리 이름[키] = 변경할 값 )
        library["해리포터"] = 2;

        // 전체 책 목록 출력
        // foreach(데이터타입 변수명 in 컬렉션)
        foreach(KeyValuePair<string , int> book in library)
        {
            Debug.Log("책 제목" + book.Key + "재고" +  book.Value);
        }

        if(library.ContainsKey("해리포터"))
        {
            Debug.Log("해리포터의 현재 재고" + library["해리포터"]);
        }

        library["해리포터"]++;

        string borrowBook = "해리포터";

        if(library.ContainsKey(borrowBook)) // 여기까지가 힌트

        // 책을 대출 & 반납하는걸 만들어봐요
        // 빌릴 & 반납할 책 변수를 선언하고 책의 재고가 1권이상 있어야지 대출할수 있습니다.
        // 절대 설명이 귀찮은게 아니야 '
        // 손들면 자유의 몸임

        // 논리 연산자
        // 1. && => 양쪽의 조건식이 참일떄 true를 반환
        // 2. || => 양쪽의 조건식중 둘중 하나가 참이여도 true를 반환
        // 삼항 연산자
        // 3. 조건식 ? 참일때 값 : 거짓일때 값
        if (library.ContainsKey(borrowBook) && library[borrowBook] >= 1)

    }
}
