Public Class Form1


    ' ' //Our channel color that we will expose later
    Protected moChannelColor As Color = Color.Empty

    '' //Our images for the scrollbar that we will expose later 
    Protected moUpArrowImage As Image = Nothing '= null
    Protected moDownArrowImage As Image = Nothing ' = null 
    Protected moThumbArrowImage As Image = Nothing ' = null 
    Protected moThumbTopImage As Image = Nothing ' = null 
    Protected moThumbTopSpanImage As Image = Nothing ' = null 
    Protected moThumbBottomImage As Image = Nothing ' = null 
    Protected moThumbBottomSpanImage As Image = Nothing ' = null 
    Protected moThumbMiddleImage As Image = Nothing ' = null 

    '' //Our properties that we will expose later 

    Protected moLargeChange As Integer = 10
    Protected moSmallChange As Integer = 1
    Protected moMinimum As Integer = 0
    Protected moMaximum As Integer = 100
    Protected moValue As Integer = 0

    ' //Our private variables for internal use 
    Private nClickPoint As Integer
    Private moThumbTop As Integer = 0
    Private moThumbDown As Boolean = False
    Private moThumbDragging As Boolean = False

    Public Btn As New Button

    '//Our public events that we are exposing

    '    Public New Event EventHandler( Scroll = null)
    'Public Event EventHandler() ValueChanged = null


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Btn = New Button


        Btn.Location = New Point(0, 900)
        Btn.Text = "testando"
        Btn.Visible = True
        InnerPanel.Controls.Add(Btn)
    End Sub


End Class
