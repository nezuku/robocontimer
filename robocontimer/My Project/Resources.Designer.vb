﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.17929
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'このクラスは StronglyTypedResourceBuilder クラスが ResGen
    'または Visual Studio のようなツールを使用して自動生成されました。
    'メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    'ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    '''<summary>
    '''  ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("robocontimer.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        '''  現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property box_blue() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("box_blue", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property box_red() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("box_red", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property icon_main() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_main", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property pngCoron() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("pngCoron", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  
        '''ロボコンタイマー 2.3
        '''Copyright(C)2005-2013 Attun
        '''
        '''------------------------------
        '''
        '''高専ロボコンで使用されるタイマーを再現したものです。タイマー機能のほか、
        '''得点カウントも可能です。画面解像度はXGA(1024x768)にあわせています。
        '''サウンドデータを実行ファイルへリソースとして埋め込んでいます。
        '''
        '''------------------------------
        '''
        '''○利用条件など
        '''本ソフトウェアは Apache Licence 2.0 の基配布されます。詳細は配布パッケージの NOTICE を参照してください
        '''
        '''○実行前に
        '''実行に当たっては.NET Framework 3.0がインストールされている必要があります。
        '''
        '''時間表示のフォントとして yu188氏作 7セグメントフォントに最適化されるようにしています。
        '''http://www.vector.co.jp/soft/win95/writing/se236648.html
        '''ダウンロードして、フォントフォルダへコピーしてください。
        '''
        '''フォントファイル [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property robocontimer() As String
            Get
                Return ResourceManager.GetString("robocontimer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property sndHigh() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("sndHigh", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property sndLow() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("sndLow", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property sndPi() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("sndPi", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  EXTENDED に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property STATUS_EXTEND() As String
            Get
                Return ResourceManager.GetString("STATUS_EXTEND", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  READY? に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property STATUS_READY() As String
            Get
                Return ResourceManager.GetString("STATUS_READY", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  SETTING に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property STATUS_SETTING() As String
            Get
                Return ResourceManager.GetString("STATUS_SETTING", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  START! に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property STATUS_START() As String
            Get
                Return ResourceManager.GetString("STATUS_START", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  STOP に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property STATUS_STOP() As String
            Get
                Return ResourceManager.GetString("STATUS_STOP", resourceCulture)
            End Get
        End Property
    End Module
End Namespace