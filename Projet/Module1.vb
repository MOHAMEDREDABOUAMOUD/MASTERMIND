Module Module1
    Public cnt, rounds As Integer
    Public time As Integer = 30
    Public f0 As Form1
    Public f1 As level_1
    Public f2 As level_2
    Public f3 As level_3
    Public f_htp As HowToPlay
    Public f_win As win
    Public f_win2 As win2
    Public f_win3 As win3
    Public f_lose As Lose
    Public multi As Multi_Player
    Public f_multi_win As multi_win
    Sub Main()
        f0 = New Form1
        f1 = New level_1
        f2 = New level_2
        f3 = New level_3
        f_htp = New HowToPlay
        f_win = New win
        f_win2 = New win2
        f_win3 = New win3
        f_lose = New Lose
        multi = New Multi_Player
        f_multi_win = New multi_win
        f0.ShowDialog()
    End Sub

End Module
