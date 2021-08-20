# OpenCVによる画像表示アプリケーション
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
