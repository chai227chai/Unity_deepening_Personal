# Chapter 3-3 Unity 게임개발 심화 개인과제 

- Unity3기_16조 신채윤

## 나만의 게임 만들어보기

### 필수 요구 사항

1. 인트로 씬 구성
   - UI 구성
   - 시작 버튼 추가
     - 시작 버튼시 씬 전환 - 메인 게임으로 이동
    
2. 자유 게임 만들기
   - 전환 된 씬에서는 본인이 만들어보고 싶은 게임을 시작
   - 내용의 제한은 없습니다.

---

### 자유 게임 구성 내용

1. 게임 구성 의도
   - 새롭게 배운 내용인 FSM과 아직은 활용법을 제대로 찾지 못했던 오브젝트 풀링을 활용하여, 간단한 피하기 게임을 만들었습니다.
   - UI들을 prefabs화 해놓고 UIManager를 이용해 불러오는 방식을 연습해 보기 위해 UIBase를 구현해 보았습니다.
  
2. 게임의 진행
   - 인트로씬
  
     ![image](https://github.com/chai227chai/Unity_deepening_Personal/assets/37549333/32637a95-3ad5-4091-bcb0-9098cbda7ab6)

     - 버튼을 따로 구현하지 않고 게임 창의 아무 곳이나 클릭해도 메인씬으로 넘어가도록 구현했습니다.
     - 해당 방식을 구현하는 방식이 따로 있는지 찾아보았으나, 찾지 못하여 그냥 Canvas에 버튼을 추가해서 넘어가는 식으로 구현했습니다.
     - 기사부분을 클릭했을시엔 게임부분으로 넘어가지 않는 오류가 있어서 이 부분은 원인을 찾아 수정할 생각입니다.
    
   - 게임의 진행
  
     ![image](https://github.com/chai227chai/Unity_deepening_Personal/assets/37549333/85bf2e59-bd6b-4250-8aa6-a334602c11a6)
     ![image](https://github.com/chai227chai/Unity_deepening_Personal/assets/37549333/1aa48299-1ef9-4be4-87b8-91a74715af76)

     - 게임이 시작되면 3초의 카운트다운 이후 start문구가 뜨면서 본격적인 피하기 게임이 시작됩니다.
    
     ![image](https://github.com/chai227chai/Unity_deepening_Personal/assets/37549333/1bbe9187-a63e-484a-bac9-180c29112494)

     - 화면 왼쪽 위 체력칸이 나타납니다. 화면 가운데에는 현재 플레이 시간이 표시됩니다.
     - 맵의 네 귀퉁이에서 플레이어 방향으로 탄환을 발사합니다. 탄환은 일정 범위에서 임의의 속도를 가집니다.
     - 이 탄환들은 정확히 플레이어 방향으로 날아오지 않고, 그 주위 근처 방향을 향해서 날아옵니다. 플레이어로 하여금 좀 더 정신 없게 만들기 위한 의도입니다.
     - 일정 주기로 네 벽면 밑에서 기둥이 나타납니다. 기둥을 한쪽 벽면에서 시작해서 반대쪽 벽면을 향해 움직입니다.

     ![image](https://github.com/chai227chai/Unity_deepening_Personal/assets/37549333/cf8edca8-31de-4c31-8ccc-9658300f56cb)
     ![image](https://github.com/chai227chai/Unity_deepening_Personal/assets/37549333/a92d2539-cda2-4339-9464-d934805a3f88)


     - 탄환과 기둥에 닿으면 체력이 감소합니다.
     - 체력이 0이 될 경우 게임오버가 되며, 현재까지 플레이한 시간이 팝업에 표시됩니다.
     - 다시하기 버튼을 누를 시 피하기 게임을 다시 도전할 수 있습니다. 메인화면으로 버튼을 누를 시 인트로 씬으로 넘어갑니다.



