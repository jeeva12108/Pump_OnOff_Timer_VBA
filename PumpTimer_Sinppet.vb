''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'''''''''''''''''''''''''''''''''''''''''''''''DevBy:[AJ]'''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''TimerFunctionForPump'''''''''''''''''''''''''''''''''''''''''''''''''''

Sub timr()
If Range("j9").Value = "On" Then
Application.OnTime Now() + TimeValue("00:00:01"), "main" 'to call the funtion main() after 1 sec from initiation
End If
End Sub

Sub main()
Range("N3").Value = Range("n3").Value + Range("j7").Value
timr 'mentioning timr here makes it a loop thus every one sec main is called
End Sub
