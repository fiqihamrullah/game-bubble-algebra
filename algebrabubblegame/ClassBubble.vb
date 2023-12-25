Public Class ClassBubble
    Dim val As String
    Dim isKonst As Boolean
    Dim isVar As Boolean
    Dim isKoef As Boolean
    Dim gbr As System.Drawing.Image
    Dim isSel As Boolean
    Dim isBingo As Boolean
    Public Sub New()

    End Sub

    Property IsSelected() As Boolean
        Get
            Return isSel
        End Get
        Set(ByVal value As Boolean)
            isSel = value
        End Set
    End Property

    Property Gambar() As System.Drawing.Image
        Get
            Return gbr
        End Get
        Set(ByVal value As System.Drawing.Image)
            gbr = value
        End Set
    End Property

    Property IsCoefficient() As Boolean
        Get
            Return isKoef
        End Get
        Set(ByVal value As Boolean)
            isKoef = value
        End Set
    End Property
    Property IsVariable() As Boolean
        Get
            Return isVar
        End Get
        Set(ByVal value As Boolean)
            isVar = value
        End Set
    End Property
    Property IsBubbleBingo() As Boolean
        Get
            Return isBingo
        End Get
        Set(ByVal value As Boolean)
            isBingo = value
        End Set
    End Property
    Property IsConstant() As Boolean
        Get
            Return isKonst
        End Get
        Set(ByVal value As Boolean)
            isKonst = value
        End Set
    End Property
    Property Value() As String
        Get
            Return val
        End Get
        Set(ByVal value As String)
            Me.val = value
        End Set
    End Property
End Class
