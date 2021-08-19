---
title: "README"
tags: ""
---

# OpenCVによる画像表示アプリケーション
## UI
![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/ab9913b86e0749a942534261a7e5b552c72a18339f6722dd19cad7b864a6fb26-image.png)

- meunestrip
- picturebox  
シンプルにmunuestripに作成したボタンをクリック(デザインでそのUIをクリックすることでイベントを作成できる)することでファイルディレクトリを表示させるイベントを定義、その画像をopencvとして読みこみ、ビットマップとして変換した後pictureboxで表示
## Opencvの導入
![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/ba36c24d54c168b7a4d34e837c3582a5c0019b517dccfbd9fe41be988e0c97c3-image.png)
プロジェクト>NuGetパッケージの管理を開けることで導入できるパッケージ一覧が表示される.

![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/d2da42d8e578b300eff3f4942201d2373bff20c2df030e2448a3c243e778ad0c-image.png)

OpenCvSharpと検索し、画像中のパッケージを選択する

これでusing OpenCvSharp;が使用できる

## 拡張機能
- Markdown Editor
- GitHub Extension for Visual Studio  

**導入方法**
![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/91c27314389c2f86b281c095e5e893b9fa813550d2f2352016787de8068d77e5-image.png)
ツール>拡張機能と更新プログラムを選択する
![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/2c7028dff4866122966283efa8920003454d521f3af863e657ef043ef87aa708-image.png)
オンラインから検索してダウンロードする

**使い方**  
  **Markdown Editor**  
  別段使い方というものはないが.mdファイルをプレビュー付きで編集することができる.
  
![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/8558cccebb857bf1a9e30b480bc11d7a1da0394e000470b23ae5931d4d6fd4e1-image.png)  
  **GitHub Extension for Visual Studio**  
  1. リポジトリの作成  
  
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/9d2dc78254c6615ef96daa46efe7d74185c9822d0cdfff33ba1345435ddf6d08-image.png)

  Github上でリモートリポジトリを作成しておく.  
  その際、.gitignoreの設定をVisual Studioを選択する。  
  ライセンスも適切に設定  
  
  2. GitHubリポジトリをクローン  
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/f1af12279f42ae832d78b82d6e951337e28ccb7d2fcff6d8d8f3b3559f3ead87-image.png)

  Visual Studioを起動し、チームエクスプローラーで、コネクトボタン(コンセントのアイコンのボタン) をクリックしてGitHub > Clone をクリックします。
  
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/7bcd82f16ccce37e795fa34d74826d2cc63e486a942cf906f8a771c84d3983ce-image.png)

  GitHub上のリポジトリが表示されるので作成したリポジトリを選択します。必要に応じてBrowseボタンをクリックしてローカルリポジトリを作成する場所を変更できます。Cloneをクリックするとローカルにリポジトリが作成されます  
**これでプロジェクトとリポジトリの接続は完了**
  2. GitHubリポジトリに変更をpush
  チームエクスプローラーでホームボタンをクリックし、プロジェクト > 変更 をクリックして変更内容をローカルリポジトリにコミットします。
  
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/f7bec83c76950e33241e80cfdff624c1dae8017398bafd1b631cebddfee18565-image.png)
  初めて変更をクリックすると、コミット時のユーザー情報を入力するダイアログが表示されます。ここで設定した内容はこのページの手順で変更できます。
 
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/52f92df80c9ed13676caaf0f906a69bd3c3b36b75b524a99b0d6dd741ca149ea-image.png)
  変更画面で、コメントを入力しすべてをコミットをクリックして追加したソリューション用のファイルをローカルリポジトリにコミットします。
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/c21976ed8092c75b07ff030f63cebc2b2891dbf3aafb83f7e42d18c3dc9d45e3-image.png)
  ローカルリポジトリに変更をコミットしたらリモートリポジトリ(GitHub上のリポジトリ)に変更をプッシュします。チームエクスプローラーでホームボタンをクリックしてから同期ボタンをクリックします。
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/a2587c31e2e394e9b57fb3923ba4e568a91d81a09922fef9976611785b390051-image.png)
  出力方向のコミットで プッシュ をクリックします。
  ![image.png](https://boostnote.io/api/teams/rrw2n9YGE/files/f61a80ce940313800ae8c22c7f4bb4eb717d0dea452c7451c6be75c8e3b0ad7a-image.png)


## 参考にしたURL
**OpenCVの導入関係**
- https://chigusa-web.com/blog/opencvsharp%E3%81%A7%E7%94%BB%E5%83%8F%E5%87%A6%E7%90%86/#OpenCVSharp
- http://tantan2014.blogspot.com/2017/11/matformpicturebox.html  


**メッセージウィンドウ**
- https://dobon.net/vb/dotnet/form/msgbox.html


**拡張機能関係**
- https://rerrahkr.hatenablog.com/entry/2017/10/05/184548
- https://www.pine4.net/Memo2/Article/Archive/how-to-clone-github-repository-with-github-extension-for-visual-studio
