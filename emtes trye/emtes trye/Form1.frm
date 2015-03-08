VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "SHAKE FORM"
   ClientHeight    =   2835
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5265
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2835
   ScaleWidth      =   5265
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   1
      Left            =   150
      Top             =   1095
   End
   Begin VB.CommandButton Command1 
      Caption         =   "SHAKE"
      Height          =   1395
      Left            =   945
      TabIndex        =   0
      Top             =   675
      Width           =   3240
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Flg1 As Integer
Public FTOP As Integer
Public FLEFT As Integer

Private Sub Command1_Click()
Timer1.Enabled = True
End Sub

Private Sub Form_Load()
Flg1 = 0
End Sub

Private Sub Timer1_Timer()
Select Case Flg1
Case 0
FTOP = Form1.Top
FLEFT = Form1.Left
Form1.Left = Form1.Left + 30
Form1.Top = Form1.Top + 30
Flg1 = Flg1 + 1
Case 1
Form1.Left = Form1.Left - 45
Form1.Top = Form1.Top - 45
Flg1 = Flg1 + 1
Case 2
Form1.Left = Form1.Left + 60
Form1.Top = Form1.Top + 60
Flg1 = Flg1 + 1
Case 3
Form1.Left = Form1.Left - 75
Form1.Top = Form1.Top - 75
Flg1 = Flg1 + 1
Case 4
Form1.Left = Form1.Left + 90
Form1.Top = Form1.Top + 90
Flg1 = Flg1 + 1
Case 5
Form1.Left = Form1.Left - 105
Form1.Top = Form1.Top - 105
Flg1 = Flg1 + 1
Case 6
Form1.Left = Form1.Left + 105
Form1.Top = Form1.Top + 105
Flg1 = Flg1 + 1
Case 7
Form1.Left = Form1.Left - 75
Form1.Top = Form1.Top - 75
Flg1 = Flg1 + 1
Case 8
Form1.Left = Form1.Left + 90
Form1.Top = Form1.Top + 90
Flg1 = Flg1 + 1
Case 9
Form1.Left = Form1.Left - 135
Form1.Top = Form1.Top - 135
Flg1 = Flg1 + 1
Case 10
Form1.Left = Form1.Left + 90
Form1.Top = Form1.Top + 90
Flg1 = Flg1 + 1
Case 11
Form1.Left = Form1.Left - 105
Form1.Top = Form1.Top - 105
Flg1 = Flg1 + 1
Case 12
Form1.Left = Form1.Left + 135
Form1.Top = Form1.Top + 135
Flg1 = Flg1 + 1
Case 13
Form1.Left = Form1.Left - 90
Form1.Top = Form1.Top - 90
Flg1 = Flg1 + 1
Case 14
Form1.Left = Form1.Left + 75
Form1.Top = Form1.Top + 75
Flg1 = Flg1 + 1
Case 15
Form1.Left = Form1.Left - 150
Form1.Top = Form1.Top - 150
Flg1 = Flg1 + 1
Case 16
Form1.Left = Form1.Left + 105
Form1.Top = Form1.Top + 105
Flg1 = Flg1 + 1
Case 17
Form1.Left = Form1.Left - 75
Form1.Top = Form1.Top - 75
Flg1 = Flg1 + 1
Case 18
Form1.Left = Form1.Left + 90
Form1.Top = Form1.Top + 90
Flg1 = Flg1 + 1
Case 19
Form1.Left = Form1.Left - 105
Form1.Top = Form1.Top - 105
Flg1 = Flg1 + 1
Case 20
Form1.Left = Form1.Left + 135
Form1.Top = Form1.Top + 135
Flg1 = Flg1 + 1
Case 21
Form1.Left = Form1.Left - 150
Form1.Top = Form1.Top - 150
Flg1 = Flg1 + 1
Case 22
Form1.Left = Form1.Left + 180
Form1.Top = Form1.Top + 180
Flg1 = Flg1 + 1
Case 23
Form1.Left = Form1.Left - 150
Form1.Top = Form1.Top - 150
Flg1 = Flg1 + 1
Case 24
Form1.Left = Form1.Left + 195
Form1.Top = Form1.Top + 195
Flg1 = Flg1 + 1
Case 25
Form1.Left = FLEFT
Form1.Top = FTOP
Flg1 = 0
Timer1.Enabled = False
End Select
End Sub
