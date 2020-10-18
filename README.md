# DualMaze
DualMaze는 VR 미로에서 동전을 수집하면서, 동시에 물리적인 미로를 통과하는 것이 목표인 게임입니다.

# 중간 과제 수행 사항
![Maze Generator Preview](https://assetstorev1-prd-cdn.unity3d.com/key-image/f88954db-b370-4f40-8014-b2ced3ce0aff.webp)
1. [Maze Generator 에셋](https://assetstore.unity.com/packages/tools/modeling/maze-generator-38689)을 수정하여 3인칭 시점을 1인칭 시점으로 변경하였습니다.
2. [Google Cardboard 라이브러리](https://developers.google.com/cardboard/develop/unity/quickstart)를 연결하여 Cardboard 환경에서 플레이할 수 있도록 수정하였습니다.
3. 동전을 바라볼 때와 바라보지 않을 때의 텍스쳐, 실행 동작을 구분하였습니다. 동전을 바라보면 동전이 빛나며, 이때 화면을 클릭하면 동전을 수집할 수 있습니다. 동전을 바라보지 않을 때 화면을 클릭하면 직진 기능을 토글합니다.
4. 동전 수집 현황을 추가하였고, 동전을 다 모으면 피드백 이후 3초 뒤 씬을 재실행합니다.

# 기말 과제 예정 사항
1. 왼쪽 눈 화면은 실시간 카메라 영상으로 대체할 예정입니다.
2. Vuforia 라이브러리를 사용하여 카메라 영상에서 물체를 인식할 예정입니다.

# 실행 방법
1. 이 레포지토리를 Clone합니다.
2. Unity Hub에서 추가를 눌러 프로젝트를 추가합니다.
3. 프로젝트를 실행한 뒤, [Assets]-[Scenes] 폴더에서 [midterm] Scene을 실행합니다.
4. Game 탭에서 [1920x1080 Landscape]로 설정되어 있는지 확인한 후 실행 버튼을 눌러 Scene을 실행합니다.
5. 레포지토리의 DualMaze_mid.apk를 설치하여 안드로이드 환경에서 앱을 실행해볼 수 있습니다.

# 테스트 기기
- Unity 2019.4.12f1 Personal, Windows 10
- Galaxy Note 8, Android 9 (API level 28)

# DualMaze
DualMaze aims to collect coins from VR mazes and pass through physical mazes at the same time.

# Midterm Progress
![Maze Generator Preview](https://assetstorev1-prd-cdn.unity3d.com/key-image/f88954db-b370-4f40-8014-b2ced3ce0aff.webp)
1. Change the third person point to the first person point by modifying [Maze Generator Asset]((https://assetstore.unity.com/packages/tools/modeling/maze-generator-38689).
2. [Google Cardboard Library](https://developers.google.com/cardboard/develop/unity/quickstart) is linked and modified to play in a Cardboard environment.
3. The texture and execution of **looking at** and **not looking at** coins are distinguished. When you look at a coin, the coin shines, and you can click on the screen to collect it. When you are not looking at a coin, click on the screen to toggle the straight ahead function.
4. Add coin collection status, and when all coins are collected, re-run the scene 3 seconds after feedback.

# Final Milestone
1. The left side of the split screen will be replaced by a live camera image.
2. Use the Vuporia library to recognize objects in camera images.

# How to execute
1. Clone this repertoire.
2. In Unity Hub, click Add to add a project.
3. After running the project, run [midterm] Scene in the [Assets]-[Scenes] folder.
4. On the Game tab, verify that it is set to [1920x1080 Landscape], then press the Run button to run Scene.
5. Install DualMaze_mid.apk in the repertoire to run apps in an Android environment.

# Tested Devices
- Unity 2019.4.12f1 Personal, Windows 10
- Galaxy Note 8, Android 9 (API level 28)
