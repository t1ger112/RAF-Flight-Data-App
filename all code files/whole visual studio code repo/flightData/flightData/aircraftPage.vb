
Imports System.Drawing.Text
Imports System.IO
Imports System.Text

Public Class aircraftPage

    'the program is only this long as the search is copied five times (for each array index of the line being searched for the searchterm)

    'README: the search feature MAY NOT work in the VS runtime environment, it has to run the executable in the same folder as the csv file.
    'if not done already, paste the CSV into the /bin/debug folder of the solution's files to use debugging, or just run the executeable...
    'predicting the filepath directory allows for the app to be installed and work properly on any directory/device as long as the install folder also contains the csv file.

    Dim aircraftType As Object
    Dim airfieldVal As Object

    'variables for storing the values of the presented airfield data
    Dim airfieldName As String
    Dim icao As String
    Dim iata As String
    Dim towerFreq As String
    Dim tacan As String
    Dim ils As String
    Dim qfe As Integer
    Dim rnyHDG1 As String
    Dim rnyHDG2 As String
    Dim rnyLNTH As String
    Dim rnyELEV As String
    Dim latitude As String
    Dim longitude As String
    Dim alerts As String
    Dim qfeCalc As String
    Dim ilsCalc As Integer
    Dim ilsPrint As String
    Dim surfaceType As String
    Dim grabSurfaceType As String
    Dim runwayWIDTH As String
    Dim hasIls As Boolean
    Dim hasTacan As Boolean
    Dim reviewQeue As Boolean

    'filedir is the directory adress of the csv file, and grabs the csv from wherever the .exe is stored, meaning they should be stored together.
    Dim path As String = My.Application.Info.DirectoryPath
    Dim filedir As String = IO.Path.Combine(path, "airportsData.csv")

    Private Sub aircraftPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_fast.Click 'button for fast-jet
        aircraftType = "FJ" 'variable for future features that change the alterts off aircraft type
        alertType.Text = "for Fast-Jet aircraft:" 'changes alerts box content type
        TXTalerts.Text = " Contextual alerts will appear here..."
        Label3.Visible = False
        PictureBox1.Visible = False 'sets the interface to show the correct content
        Label1.Visible = False
        BTN_home.Visible = True
        PictureBox2.Visible = True
        TextBoxPrimary.Visible = True
        ButtonCLEAR.Visible = True
        BTNsearch.Visible = True
        PNLdata.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_multi.Click 'button for multi engine
        aircraftType = "MW" 'variable for future features that change the alterts off aircraft type
        alertType.Text = "for Multi-Engine aircraft:" 'changes alerts box content type
        TXTalerts.Text = " Contextual alerts will appear here..." 'changes alerts box content
        Label3.Visible = False
        PictureBox1.Visible = False 'sets the interface to show the correct content
        Label1.Visible = False
        BTN_home.Visible = True
        PictureBox2.Visible = True
        TextBoxPrimary.Visible = True
        ButtonCLEAR.Visible = True
        BTNsearch.Visible = True
        PNLdata.Visible = True

    End Sub

    Private Sub BTN_rotary_Click(sender As Object, e As EventArgs) Handles BTN_rotary.Click 'button for helis
        aircraftType = "RW" 'variable for future features that change the alterts off aircraft type
        alertType.Text = "for Rotary-Wing aircraft:" 'changes alerts box content type
        TXTalerts.Text = " Contextual alerts will appear here..." 'changes alerts box content
        Label3.Visible = False
        PictureBox1.Visible = False 'sets the interface to show the correct content
        Label1.Visible = False
        BTN_home.Visible = True
        PictureBox2.Visible = True
        TextBoxPrimary.Visible = True
        ButtonCLEAR.Visible = True
        BTNsearch.Visible = True
        PNLdata.Visible = True
    End Sub

    Private Sub BTN_home_Click(sender As Object, e As EventArgs) Handles BTN_home.Click
        Label3.Visible = True
        PictureBox1.Visible = True
        Label1.Visible = True
        BTN_home.Visible = False
        PictureBox2.Visible = False  'sets the interface to show the correct content (homepage) upon the home button being pressed
        TextBoxPrimary.Visible = False
        ButtonCLEAR.Visible = False
        BTNsearch.Visible = False
        PNLdata.Visible = False
        TextBox1.Visible = False

        TextBoxPrimary.Text = "" 'resets the searchbox that the airfiels are entered into
        'resets airport data:
        TXTairfiedFound.Text = ""
        Ticao.Text = ""
        Tiata.Text = ""
        Tfreq.Text = ""
        Ttacan.Text = ""
        Tils.Text = ""
        Tqfe.Text = ""
        Thdg.Text = ""
        Tlngth.Text = ""
        Telev.Text = ""
        Tlat.Text = ""
        Tlong.Text = ""
        TXTalerts.Text = " Contextual alerts will appear here..."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCLEAR.Click
        TextBoxPrimary.Text = "" 'resets the searchbox that the airfiels are entered into
        TextBox1.Visible = False 'hides the red review notice above the alerts box

        'resets airport data and formats the interface:
        TXTairfiedFound.Text = ""
        Ticao.Text = ""
        Tiata.Text = ""
        Tfreq.Text = ""
        Ttacan.Text = ""
        Tils.Text = ""
        Tqfe.Text = ""
        Thdg.Text = ""
        Tlngth.Text = ""
        Telev.Text = ""
        Tlat.Text = ""
        Tlong.Text = ""
        TXTalerts.Text = " Contextual alerts will appear here..."
    End Sub

    Function readrecord(ByVal filepath As String, ByVal searchTerm As String, ByVal delimiter As String, ByVal searchTermPosition As Integer) As String
        searchTermPosition -= 1
        Dim currentLine As String 'variable for the line of csv being read  
        Dim found As Boolean 'variable for true/false of the search term being found
        found = False 'sets to false at the start of the program

        'I am fairly new to VB which I started learning for A-Level Computer Science, so I utilised this video to help me structure some of the more compex workings of this search function:
        'https://youtu.be/XRQfW5amxEA?si=O9DJzxpGTYg3Zp5Y

        'search function workings:
        Try
            Dim fileReader As New System.IO.StreamReader(filepath) 'reads file grabbed from the predicted location of filepath variable
            Do While fileReader.Peek() <> -1 'peeks the first line in the csv to read
                currentLine = fileReader.ReadLine() 'reads current line being searched
                Dim currentRecord() As String = Split(currentLine, delimiter) 'uses the csv commas to split and make an array out of values

                'if comparison functions that check if a specific index of the array holds the searchterm value, then sets the airfield data from the other columns
                If (String.Compare(currentRecord(1), searchTerm) = 0) Then 'searches first column of the current row if it is the search term
                    airfieldVal = currentLine 'saves the whole array line to be printed to console for debbuging purposes

                    airfieldName = currentRecord(3)
                    TXTairfiedFound.Text = " " + airfieldName 'sets the airfield name to relevant textbox
                    icao = currentRecord(7)
                    Ticao.Text = " " + icao 'sets the icao nav code to relevant textbox
                    iata = currentRecord(8)
                    Tiata.Text = " " + iata 'sets the iata nav code to relevant textbox
                    Tfreq.Text = " Frequencey Unavailable" 'sets placeholder value for tower freq
                    tacan = currentRecord(18)
                    If tacan = "" Then 'prints tacan if it has one
                        Ttacan.Text = " Tacan Unavailable" 'sets placeholder value for tacan
                        hasTacan = False
                    Else
                        Ttacan.Text = " " + tacan
                        hasTacan = True
                    End If
                    ils = currentRecord(17)
                    If ils = "" Then 'prints ils if it has one
                        Tils.Text = " ILS Unavailable" 'sets placeholder value for ils
                        hasIls = False
                    Else
                        ilsCalc = ils 'makes the ils value into correct format: ***.**Mhz
                        ilsPrint = ilsCalc / 1000
                        Tils.Text = " " + ilsPrint + "0" + " Mhz"
                        hasIls = True
                    End If
                    qfe = currentRecord(6)
                    qfeCalc = Math.Round(qfe / 30, 2, MidpointRounding.AwayFromZero) 'finds qfe in mb from the elevation so it can be used to find an aircrafts true qfe (QNH - QFE mb = QFE)
                    Tqfe.Text = " " + qfeCalc + " mb"
                    rnyHDG1 = currentRecord(15)
                    rnyHDG2 = currentRecord(16)
                    Thdg.Text = " " + rnyHDG1 + ", " + rnyHDG2
                    rnyLNTH = currentRecord(10)
                    Tlngth.Text = " " + rnyLNTH + " ft"
                    rnyELEV = currentRecord(6)                      'sets the relevant data accordingly based of the csv values
                    Telev.Text = " " + rnyELEV + " ft"
                    latitude = currentRecord(4)
                    Tlat.Text = " N " + latitude
                    longitude = currentRecord(5)
                    Tlong.Text = " E " + longitude
                    alerts = currentRecord(2)
                    surfaceType = currentRecord(12)
                    runwayWIDTH = currentRecord(11)
                    'hard surfaces codes listed to change the codes to the word hard in the alerts box
                    If surfaceType = "ASP" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "CON" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "ASPH" Then
                        surfaceType = " hard"
                    End If
                    'soft surfaces surfaces codes listed to change the codes to the word soft in the alerts box
                    If surfaceType = "TURF" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "Grass" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRS" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRVL" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GVL" Then
                        surfaceType = " soft"
                    End If
                    'generation of the alerts text, which has a different output dependent on if it doesn't have a tacan or ils, and if one is missing then it calls the review queue
                    If hasIls = False Then
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport may have no TACAN, and also might not support ILS landings."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport also may not support ILS landings."
                            reviewQeue = True
                        End If
                    Else
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport might have no TACAN."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide."
                            reviewQeue = False
                        End If
                    End If
                    If reviewQeue = True Then 'decides if the red REVIEW alert is generated
                        TextBox1.Visible = True
                    Else
                        TextBox1.Visible = False
                    End If

                    found = True 'sets the value to found so that it can output if there is no record found
                    Return currentLine 'console output for debugging purposes
                End If
                If (String.Compare(currentRecord(3), searchTerm) = 0) Then 'searches specific indexed column of the current row if it is the search term
                    airfieldVal = currentLine 'saves the whole array line to be printed to console for debbuging purposes

                    airfieldName = currentRecord(3)
                    TXTairfiedFound.Text = " " + airfieldName 'sets the airfield name to relevant textbox
                    icao = currentRecord(7)
                    Ticao.Text = " " + icao 'sets the icao nav code to relevant textbox
                    iata = currentRecord(8)
                    Tiata.Text = " " + iata 'sets the iata nav code to relevant textbox
                    Tfreq.Text = " Frequencey Unavailable" 'sets placeholder value for tower freq
                    tacan = currentRecord(18)
                    If tacan = "" Then 'prints tacan if it has one
                        Ttacan.Text = " Tacan Unavailable" 'sets placeholder value for tacan
                        hasTacan = False
                    Else
                        Ttacan.Text = " " + tacan
                        hasTacan = True
                    End If
                    ils = currentRecord(17)
                    If ils = "" Then 'prints ils if it has one
                        Tils.Text = " ILS Unavailable" 'sets placeholder value for ils
                        hasIls = False
                    Else
                        ilsCalc = ils 'makes the ils value into correct format: ***.**Mhz
                        ilsPrint = ilsCalc / 1000
                        Tils.Text = " " + ilsPrint + "0" + " Mhz"
                        hasIls = True
                    End If
                    qfe = currentRecord(6)
                    qfeCalc = Math.Round(qfe / 30, 2, MidpointRounding.AwayFromZero) 'finds qfe in mb from the elevation so it can be used to find an aircrafts true qfe (QNH - QFE mb = QFE)
                    Tqfe.Text = " " + qfeCalc + " mb"
                    rnyHDG1 = currentRecord(15)
                    rnyHDG2 = currentRecord(16)
                    Thdg.Text = " " + rnyHDG1 + ", " + rnyHDG2
                    rnyLNTH = currentRecord(10)
                    Tlngth.Text = " " + rnyLNTH + " ft"
                    rnyELEV = currentRecord(6)                      'sets the relevant data accordingly based of the csv values
                    Telev.Text = " " + rnyELEV + " ft"
                    latitude = currentRecord(4)
                    Tlat.Text = " N " + latitude
                    longitude = currentRecord(5)
                    Tlong.Text = " E " + longitude
                    alerts = currentRecord(2)
                    surfaceType = currentRecord(12)
                    runwayWIDTH = currentRecord(11)
                    'hard surfaces codes listed to change the codes to the word hard in the alerts box
                    If surfaceType = "ASP" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "CON" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "ASPH" Then
                        surfaceType = " hard"
                    End If
                    'soft surfaces surfaces codes listed to change the codes to the word soft in the alerts box
                    If surfaceType = "TURF" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "Grass" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRS" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRVL" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GVL" Then
                        surfaceType = " soft"
                    End If
                    'generation of the alerts text, which has a different output dependent on if it doesn't have a tacan or ils, and if one is missing then it calls the review queue
                    If hasIls = False Then
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport may have no TACAN, and also might not support ILS landings."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport also may not support ILS landings."
                            reviewQeue = True
                        End If
                    Else
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport might have no TACAN."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide."
                            reviewQeue = False
                        End If
                    End If
                    If reviewQeue = True Then 'decides if the red REVIEW alert is generated
                        TextBox1.Visible = True
                    Else
                        TextBox1.Visible = False
                    End If

                    found = True
                    Return currentLine
                End If
                If (String.Compare(currentRecord(7), searchTerm) = 0) Then 'searches specific indexed column of the current row if it is the search term
                    airfieldVal = currentLine 'saves the whole array line to be printed to console for debbuging purposes

                    airfieldName = currentRecord(3)
                    TXTairfiedFound.Text = " " + airfieldName 'sets the airfield name to relevant textbox
                    icao = currentRecord(7)
                    Ticao.Text = " " + icao 'sets the icao nav code to relevant textbox
                    iata = currentRecord(8)
                    Tiata.Text = " " + iata 'sets the iata nav code to relevant textbox
                    Tfreq.Text = " Frequencey Unavailable" 'sets placeholder value for tower freq
                    tacan = currentRecord(18)
                    If tacan = "" Then 'prints tacan if it has one
                        Ttacan.Text = " Tacan Unavailable" 'sets placeholder value for tacan
                        hasTacan = False
                    Else
                        Ttacan.Text = " " + tacan
                        hasTacan = True
                    End If
                    ils = currentRecord(17)
                    If ils = "" Then 'prints ils if it has one
                        Tils.Text = " ILS Unavailable" 'sets placeholder value for ils
                        hasIls = False
                    Else
                        ilsCalc = ils 'makes the ils value into correct format: ***.**Mhz
                        ilsPrint = ilsCalc / 1000
                        Tils.Text = " " + ilsPrint + "0" + " Mhz"
                        hasIls = True
                    End If
                    qfe = currentRecord(6)
                    qfeCalc = Math.Round(qfe / 30, 2, MidpointRounding.AwayFromZero) 'finds qfe in mb from the elevation so it can be used to find an aircrafts true qfe (QNH - QFE mb = QFE)
                    Tqfe.Text = " " + qfeCalc + " mb"
                    rnyHDG1 = currentRecord(15)
                    rnyHDG2 = currentRecord(16)
                    Thdg.Text = " " + rnyHDG1 + ", " + rnyHDG2
                    rnyLNTH = currentRecord(10)
                    Tlngth.Text = " " + rnyLNTH + " ft"
                    rnyELEV = currentRecord(6)                      'sets the relevant data accordingly based of the csv values
                    Telev.Text = " " + rnyELEV + " ft"
                    latitude = currentRecord(4)
                    Tlat.Text = " N " + latitude
                    longitude = currentRecord(5)
                    Tlong.Text = " E " + longitude
                    alerts = currentRecord(2)
                    surfaceType = currentRecord(12)
                    runwayWIDTH = currentRecord(11)
                    'hard surfaces codes listed to change the codes to the word hard in the alerts box
                    If surfaceType = "ASP" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "CON" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "ASPH" Then
                        surfaceType = " hard"
                    End If
                    'soft surfaces surfaces codes listed to change the codes to the word soft in the alerts box
                    If surfaceType = "TURF" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "Grass" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRS" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRVL" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GVL" Then
                        surfaceType = " soft"
                    End If
                    'generation of the alerts text, which has a different output dependent on if it doesn't have a tacan or ils, and if one is missing then it calls the review queue
                    If hasIls = False Then
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport may have no TACAN, and also might not support ILS landings."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport also may not support ILS landings."
                            reviewQeue = True
                        End If
                    Else
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport might have no TACAN."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide."
                            reviewQeue = False
                        End If
                    End If
                    If reviewQeue = True Then 'decides if the red REVIEW alert is generated
                        TextBox1.Visible = True
                    Else
                        TextBox1.Visible = False
                    End If

                    found = True
                    Return currentLine
                End If
                If (String.Compare(currentRecord(8), searchTerm) = 0) Then 'searches specific indexed column of the current row if it is the search term
                    airfieldVal = currentLine 'saves the whole array line to be printed to console for debbuging purposes

                    airfieldName = currentRecord(3)
                    TXTairfiedFound.Text = " " + airfieldName 'sets the airfield name to relevant textbox
                    icao = currentRecord(7)
                    Ticao.Text = " " + icao 'sets the icao nav code to relevant textbox
                    iata = currentRecord(8)
                    Tiata.Text = " " + iata 'sets the iata nav code to relevant textbox
                    Tfreq.Text = " Frequencey Unavailable" 'sets placeholder value for tower freq
                    tacan = currentRecord(18)
                    If tacan = "" Then 'prints tacan if it has one
                        Ttacan.Text = " Tacan Unavailable" 'sets placeholder value for tacan
                        hasTacan = False
                    Else
                        Ttacan.Text = " " + tacan
                        hasTacan = True
                    End If
                    ils = currentRecord(17)
                    If ils = "" Then 'prints ils if it has one
                        Tils.Text = " ILS Unavailable" 'sets placeholder value for ils
                        hasIls = False
                    Else
                        ilsCalc = ils 'makes the ils value into correct format: ***.**Mhz
                        ilsPrint = ilsCalc / 1000
                        Tils.Text = " " + ilsPrint + "0" + " Mhz"
                        hasIls = True
                    End If
                    qfe = currentRecord(6)
                    qfeCalc = Math.Round(qfe / 30, 2, MidpointRounding.AwayFromZero) 'finds qfe in mb from the elevation so it can be used to find an aircrafts true qfe (QNH - QFE mb = QFE)
                    Tqfe.Text = " " + qfeCalc + " mb"
                    rnyHDG1 = currentRecord(15)
                    rnyHDG2 = currentRecord(16)
                    Thdg.Text = " " + rnyHDG1 + ", " + rnyHDG2
                    rnyLNTH = currentRecord(10)
                    Tlngth.Text = " " + rnyLNTH + " ft"
                    rnyELEV = currentRecord(6)                      'sets the relevant data accordingly based of the csv values
                    Telev.Text = " " + rnyELEV + " ft"
                    latitude = currentRecord(4)
                    Tlat.Text = " N " + latitude
                    longitude = currentRecord(5)
                    Tlong.Text = " E " + longitude
                    alerts = currentRecord(2)
                    surfaceType = currentRecord(12)
                    runwayWIDTH = currentRecord(11)
                    'hard surfaces codes listed to change the codes to the word hard in the alerts box
                    If surfaceType = "ASP" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "CON" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "ASPH" Then
                        surfaceType = " hard"
                    End If
                    'soft surfaces surfaces codes listed to change the codes to the word soft in the alerts box
                    If surfaceType = "TURF" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "Grass" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRS" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRVL" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GVL" Then
                        surfaceType = " soft"
                    End If
                    'generation of the alerts text, which has a different output dependent on if it doesn't have a tacan or ils, and if one is missing then it calls the review queue
                    If hasIls = False Then
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport may have no TACAN, and also might not support ILS landings."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport also may not support ILS landings."
                            reviewQeue = True
                        End If
                    Else
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport might have no TACAN."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide."
                            reviewQeue = False
                        End If
                    End If
                    If reviewQeue = True Then 'decides if the red REVIEW alert is generated
                        TextBox1.Visible = True
                    Else
                        TextBox1.Visible = False
                    End If

                    found = True
                    Return currentLine
                End If

                If (String.Compare(currentRecord(19), searchTerm) = 0) Then 'searches specific indexed column of the current row if it is the search term
                    airfieldVal = currentLine 'saves the whole array line to be printed to console for debbuging purposes

                    airfieldName = currentRecord(3)
                    TXTairfiedFound.Text = " " + airfieldName 'sets the airfield name to relevant textbox
                    icao = currentRecord(7)
                    Ticao.Text = " " + icao 'sets the icao nav code to relevant textbox
                    iata = currentRecord(8)
                    Tiata.Text = " " + iata 'sets the iata nav code to relevant textbox
                    Tfreq.Text = " Frequencey Unavailable" 'sets placeholder value for tower freq
                    tacan = currentRecord(18)
                    If tacan = "" Then 'prints tacan if it has one
                        Ttacan.Text = " Tacan Unavailable" 'sets placeholder value for tacan
                        hasTacan = False
                    Else
                        Ttacan.Text = " " + tacan
                        hasTacan = True
                    End If
                    ils = currentRecord(17)
                    If ils = "" Then 'prints ils if it has one
                        Tils.Text = " ILS Unavailable" 'sets placeholder value for ils
                        hasIls = False
                    Else
                        ilsCalc = ils 'makes the ils value into correct format: ***.**Mhz
                        ilsPrint = ilsCalc / 1000
                        Tils.Text = " " + ilsPrint + "0" + " Mhz"
                        hasIls = True
                    End If
                    qfe = currentRecord(6)
                    qfeCalc = Math.Round(qfe / 30, 2, MidpointRounding.AwayFromZero) 'finds qfe in mb from the elevation so it can be used to find an aircrafts true qfe (QNH - QFE mb = QFE)
                    Tqfe.Text = " " + qfeCalc + " mb"
                    rnyHDG1 = currentRecord(15)
                    rnyHDG2 = currentRecord(16)
                    Thdg.Text = " " + rnyHDG1 + ", " + rnyHDG2
                    rnyLNTH = currentRecord(10)
                    Tlngth.Text = " " + rnyLNTH + " ft"
                    rnyELEV = currentRecord(6)                      'sets the relevant data accordingly based of the csv values
                    Telev.Text = " " + rnyELEV + " ft"
                    latitude = currentRecord(4)
                    Tlat.Text = " N " + latitude
                    longitude = currentRecord(5)
                    Tlong.Text = " E " + longitude
                    alerts = currentRecord(2)
                    surfaceType = currentRecord(12)
                    runwayWIDTH = currentRecord(11)
                    'hard surfaces codes listed to change the codes to the word hard in the alerts box
                    If surfaceType = "ASP" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "CON" Then
                        surfaceType = " hard"
                    End If
                    If surfaceType = "ASPH" Then
                        surfaceType = " hard"
                    End If
                    'soft surfaces surfaces codes listed to change the codes to the word soft in the alerts box
                    If surfaceType = "TURF" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "Grass" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRS" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GRVL" Then
                        surfaceType = " soft"
                    End If
                    If surfaceType = "GVL" Then
                        surfaceType = " soft"
                    End If
                    'generation of the alerts text, which has a different output dependent on if it doesn't have a tacan or ils, and if one is missing then it calls the review queue
                    If hasIls = False Then
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport may have no TACAN, and also might not support ILS landings."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport also may not support ILS landings."
                            reviewQeue = True
                        End If
                    Else
                        If hasTacan = False Then
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide. This airport might have no TACAN."
                            reviewQeue = True
                        Else
                            TXTalerts.Text = "This is a " + alerts + "  with a" + surfaceType + " surface for a runway that is " + runwayWIDTH + " ft wide."
                            reviewQeue = False
                        End If
                    End If
                    If reviewQeue = True Then 'decides if the red REVIEW alert is generated
                        TextBox1.Visible = True
                    Else
                        TextBox1.Visible = False
                    End If

                    found = True
                    Return currentLine
                End If
            Loop

        Catch ex As Exception
            Console.WriteLine(ex) 'debugging purposes to output to console the array of airfield data
        End Try

        While found = False 'outputs that the airfield is not found if this value is false
            TXTairfiedFound.Text = " Sorry, Airfield Not Found"
            found = True
        End While

        Return "Not Found" 'debugging purposes to output to console that searchterm is not found
    End Function

    Private Sub BTNsearch_Click(sender As Object, e As EventArgs) Handles BTNsearch.Click
        Dim searcher = TextBoxPrimary.Text 'sets the searchterm as the inputted string value
        Console.WriteLine("csv data predicted at file directory:  " + filedir)  'debugging purposes to output to console where the csv file should be stored
        'filedir is now the directory adress of the csv file, and grabs the csv from the folder wherever the .exe is also stored
        Console.WriteLine(readrecord(filedir, searcher, ",", 1)) 'debugging purposes to output to console what data it actually finds on an airfield, as an array

    End Sub

End Class