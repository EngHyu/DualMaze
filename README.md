# DualMaze
DualMaze는 VR 미로에서 동전을 수집하면서, 동시에 물리적인 미로를 통과하는 것이 목표인 게임입니다.

# 중간 과제 수행 사항
![Maze Generator Preview](https://assetstorev1-prd-cdn.unity3d.com/key-image/f88954db-b370-4f40-8014-b2ced3ce0aff.webp)
1. [Maze Generator 에셋](https://assetstore.unity.com/packages/tools/modeling/maze-generator-38689)을 수정하여 3인칭 시점을 1인칭 시점으로 변경하였습니다.
2. [Google Cardboard 라이브러리](https://developers.google.com/cardboard/develop/unity/quickstart)를 연결하여 Cardboard 환경에서 플레이할 수 있도록 수정하였습니다.
3. 동전을 바라볼 때와 바라보지 않을 때의 텍스쳐, 실행 동작을 구분하였습니다. 동전을 바라보면 동전이 빛나며, 이때 화면을 클릭하면 동전을 수집할 수 있습니다. 동전을 바라보지 않을 때 화면을 클릭하면 직진 기능을 토글합니다.
4. 동전 수집 현황을 추가하였고, 동전을 다 모으면 피드백 이후 3초 뒤 씬을 재실행합니다.

# 기말 과제 예정 사항
1. 분할된 화면 중 왼쪽은 실시간 카메라 영상으로 대체할 예정입니다.
2. Vuforia 라이브러리를 사용하여 카메라 영상에서 물체를 인식할 예정입니다.
