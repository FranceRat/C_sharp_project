﻿# OpenCVによる画像表示アプリケーション
## UI
![image](https://user-images.githubusercontent.com/84693808/130054599-5e082039-6f98-4f63-8212-bed60bc75085.png)


- meunestrip
- picturebox  
シンプルにmunuestripに作成したボタンをクリック(デザインでそのUIをクリックすることでイベントを作成できる)することでファイルディレクトリを表示させるイベントを定義、その画像をopencvとして読みこみ、ビットマップとして変換した後pictureboxで表示
## Opencvの導入
![image](https://user-images.githubusercontent.com/84693808/130055031-080d24be-49b5-4fb2-8528-db88e9f63c97.png)

プロジェクト>NuGetパッケージの管理を開けることで導入できるパッケージ一覧が表示される.

![image](https://user-images.githubusercontent.com/84693808/130055071-9ec14392-9ecc-46ca-ab10-037fa0136dd4.png)

OpenCvSharpと検索し、画像中のパッケージを選択する

これでusing OpenCvSharp;が使用できる

## 拡張機能
- Markdown Editor
- GitHub Extension for Visual Studio  

**導入方法**  
![image](https://user-images.githubusercontent.com/84693808/130055139-a3e9b3f9-f1a2-4e55-8223-454cfbfb8147.png)  
ツール>拡張機能と更新プログラムを選択する  
![image](https://user-images.githubusercontent.com/84693808/130055205-85a011a2-e00f-4aa5-881c-d8940a592723.png)

オンラインから検索してダウンロードする

**使い方**  
  **Markdown Editor**  
  別段使い方というものはないが.mdファイルをプレビュー付きで編集することができる.
  
  ![image](https://user-images.githubusercontent.com/84693808/130055259-d60a0031-4153-48fb-b29c-31ef8f32b8e8.png)   
  
  
  **GitHub Extension for Visual Studio**  
  1. リポジトリの作成  
  
  ![image](https://user-images.githubusercontent.com/84693808/130055305-559d974c-4fa4-411c-8519-0ff82f1e68a4.png)  
  Github上でリモートリポジトリを作成しておく.  
  その際、.gitignoreの設定をVisual Studioを選択する。  
  ライセンスも適切に設定  
  
  2. GitHubリポジトリをクローン  
  
  ![image](https://user-images.githubusercontent.com/84693808/130055357-33177685-d16f-4846-b477-fb7dd49a66f4.png)  
  Visual Studioを起動し、チームエクスプローラーで、コネクトボタン(コンセントのアイコンのボタン) をクリックしてGitHub > Clone をクリックします。
  
  ![image](https://user-images.githubusercontent.com/84693808/130055382-7b3d49ea-55a2-4608-a59b-fb4235db68aa.png)  
  GitHub上のリポジトリが表示されるので作成したリポジトリを選択します。必要に応じてBrowseボタンをクリックしてローカルリポジトリを作成する場所を変更できます。Cloneをクリックするとローカルにリポジトリが作成されます  
**これでプロジェクトとリポジトリの接続は完了**
  2. GitHubリポジトリに変更をpush  
  チームエクスプローラーでホームボタンをクリックし、プロジェクト > 変更 をクリックして変更内容をローカルリポジトリにコミットします。  
  
  ![image](https://user-images.githubusercontent.com/84693808/130055416-188bc4b5-d8a2-44a6-8d37-4ed264447a22.png)  
  初めて変更をクリックすると、コミット時のユーザー情報を入力するダイアログが表示されます。ここで設定した内容はこのページの手順で変更できます。  
 
  ![image](https://user-images.githubusercontent.com/84693808/130055449-223103db-f23c-483a-9946-114de1a02216.png)  
  変更画面で、コメントを入力しすべてをコミットをクリックして追加したソリューション用のファイルをローカルリポジトリにコミットします。  
  ![image](https://user-images.githubusercontent.com/84693808/130055482-0cb0eed8-6a96-41bb-974e-efde6b4a2d77.png)  
  ローカルリポジトリに変更をコミットしたらリモートリポジトリ(GitHub上のリポジトリ)に変更をプッシュします。チームエクスプローラーでホームボタンをクリックしてから同期ボタンをクリックします。  
  ![image](https://user-images.githubusercontent.com/84693808/130055531-e4e026a1-0128-46ce-8b2f-cd3c28e18f91.png)  
  出力方向のコミットで プッシュ をクリックします。  
  ![image](https://user-images.githubusercontent.com/84693808/130055565-f4821c4a-06a0-495b-b579-f0a6fe2862b1.png)  


## 参考にしたURL
**OpenCVの導入関係**
- https://chigusa-web.com/blog/opencvsharp%E3%81%A7%E7%94%BB%E5%83%8F%E5%87%A6%E7%90%86/#OpenCVSharp
- http://tantan2014.blogspot.com/2017/11/matformpicturebox.html  


**メッセージウィンドウ**
- https://dobon.net/vb/dotnet/form/msgbox.html


**拡張機能関係**
- https://rerrahkr.hatenablog.com/entry/2017/10/05/184548
- https://www.pine4.net/Memo2/Article/Archive/how-to-clone-github-repository-with-github-extension-for-visual-studio

# 8/20追加
## 変更内容
 画像変換処理変換用のUIの追加とResize処理の実行  
## 追加したUI
 ![image](https://user-images.githubusercontent.com/84693808/130211648-7eb0f08a-e81b-4812-a6ce-f3e83c952d19.png)  

 - ComboBox
 - Label
 - TextBox(初期非表示) 
## Resizeでの仕様
ComboBoxのイベントを使用する.
- DropDown:コンボボックスが開かれた際に起こすイベント。本アプリでは現在選ばれている要素と紐づいているコントロールを非表示にする(Controls.Remove(T);)
- DropDownClosed:コンボボックスが閉じられた際に起こすイベント。選ばれた要素に応じて紐づいているコントロールを表示する.(Controls.Add(T);)  
Resizeにて表示されたtextboxに数値を入力することでそのサイズに合わせた画像を表示させる.

# 8/22追加
## 変更内容
 Crop用のUIの設置とpicturebox中のマウス処理に関するイベントの作成
## 追加したUI

![スクリーンショット (52)](https://user-images.githubusercontent.com/84693808/130351398-750d0b2e-a28d-4056-ac55-049e0442d744.png)

 - Label
 - TextBox(初期非表示)

## 追加したイベント
 - picturebox内でのマウスクリック時にその始点を記録する(DrawBox_start)
 - クリックが押されている間、マウスのいる点で終点として逐次更新する(pictureBox2_MouseMove)
 - クリックから離した際にに最終的な終点として記録する(DrawBoxEnd)  
 これら3つがCropモードになった際にイベントして追加され、そのモードから外れればイベントから外す

## TODO
1. Timerイベントの追加
2. 画像上に四角形を描画する関数作成
3. Timerイベントに２とpictureboxをRefreshする処理を追加する
4. UIの非表示処理
5. Crop処理を追加した(b_x1,b_x2,b_y1,b_y2からpictureboxの画像サイズと本物画像のサイズの比率を考慮してクリッピングを実行)

# 8/28 追加
## 変更内容
![スクリーンショット (54)](https://user-images.githubusercontent.com/84693808/131213830-4818f3dd-b267-47fd-a30d-5d625713e187.png)

マウス処理をpictureBoxに接続した。つまり、マウスのボタンがpictureBox上でクリックされると、ボックスの端点（始点と終点）をその位置に初期化+pictureBoxに端点から得られたボックスを表示させる。マウスがボタンが押されたまま動かれている場合、終点のみを更新+pictureboxにboxを描かせる。
ボタンが離されると終点更新.  
textboxとマウス処理の連動。マウスボタン押した時、始点のポイントを表示。ドラッグ中は終点更新（textも随時変わる）、ボタン離すと終点表示+元画像サイズ/pictureboxで補正したクロップ後のサイズをReadOnlyに指定したテキストにて表示する。  
ComboBoxの選択によってUI表示.

## 追加したUI
なし
## 追加したイベント
なし
## TODO
1. text入力からCrop領域表示の更新
2. Crop処理を追加した(b_x1,b_x2,b_y1,b_y2からpictureboxの画像サイズと本物画像のサイズの比率を考慮してクリッピングを実行)

# 8/31　追加
## 変更内容
8/28日に追加した範囲指定に対してOpenCVにてクロップ処理を実行するボタンイベントを作成した
## 追加したUI
なし
## 追加したイベント
TextChange：テキストに変更が加わると実行するされるイベント<br>
ここに入力される内容が数字として認識できる場合選択範囲を更新する.<br>
もし数字でないのだとすれば入力は何の意味を持たなくする

# 9/05
## 変更内容
![スクリーンショット (55)](https://user-images.githubusercontent.com/84693808/132115264-16600855-cffb-4fd1-ac53-41ac61a265eb.png)<br>
フィルタ処理を行う機能位の追加とForm1のpartialクラスを作成して、この中にフィルタ処理を行う関数とクラスを設置することにした。このクラス内で画像もフィルタ処理を実装する。

※後、エラー処理として、Crop時の画像中の赤枠がResizeに移っても残っているという問題が発生すしていたので、PaintingRect関数に初期化機能を持たせてCombolistが開かれた際に初期化するようにした.


## 追加したUI
- Label
- textBox
- TrackBar(スライダー)

## 追加したイベントなし
まだ追加していない

## TODO
- イベントに処理を追加する
- それぞれの処理に合わせたPaintingRectを作成する
- cv_imgがなければ（画像が開かれなければ）Comboboxは表示されないようにする
- UIはコンボリストで選ばれるまで見えないようにする

# 9/08
## 変更内容
画像切り取り、画像貼り付け、ラプラシアンフィルタ処理、Blur処理、GaussianBlur、MedianBlur、BilateralBlur、モザイク処理
の処理を行う関数を作成

## 追加したUI
なし

## 追加したイベントなし
なし

## TODO
- イベントに処理を追加する(切り取り->処理->貼り付け)
- それぞれの処理に合わせたPaintingRectを作成する
- cv_imgがなければ（画像が開かれなければ）Comboboxは表示されないようにする
- UIはコンボリストで選ばれるまで見えないようにする

# 9/09
 
## 変更内容
9/8に作成した関数を利用してFilterPaintを作成、これをRectpaintと置き換えた。UIの非表示、イベント処理の追加

## 追加したUI
なし

## 追加したイベント
- テキスト変更による対象Rectの変更
- Rectを変換した後テキスト変更
- スライダーを変更したらそれをフィルタ処理の挙動変更

## TODO
- 画像保存の処理を記述する
- cv_imgがなければ（画像が開かれなければ）Comboboxは表示されないようにする
- UIはコンボリストで選ばれるまで見えないようにする
