using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // 점수 5개를 저장할 int형 배열 생성
    public int[] scores = new int[5];

    void Start()
    {
        // 배열의 각 칸에 점수 넣기
        scores[0] = 60;
        scores[1] = 95;
        scores[2] = 133;
        scores[3] = 85;
        scores[4] = 55;

        // 총합을 저장할 변수
        int sum = 0;

        // 최고 점수를 저장할 변수
        int maxScore = 0;

        Debug.Log("배열 실습");

        // 배열의 모든 값을 출력하면서 총합과 최고점수 구하기 
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log($"{i + 1} 번째 점수 : {scores[i]}");

            // 총합에 현재 점수 더하기
            sum += scores[i];

            // 현재 점수가 최고 점수보다 크면 최고 점수 갱신
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
            }
        }

        // 형변환
        // (변환할 자료형)변환할 변수 => 변환할 자료형으로 변수의 자료형이 바뀝니다.
        float average = (float)sum / scores.Length;

        Debug.Log("총합 " + sum);
        Debug.Log("평균 " + average);
        Debug.Log("최고점수 " + maxScore);
    }
}
