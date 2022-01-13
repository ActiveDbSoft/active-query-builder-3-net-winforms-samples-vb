Namespace QueryBuilderProperties
    Partial Friend Class MiscellaneousPage
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing


        #Region "Component Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.label7 = New Label()
            Me.comboLinksStyle = New ComboBox()
            Me.SuspendLayout()
            '
            ' label7
            '
            Me.label7.Location = New Point(3, 6)
            Me.label7.Name = "label7"
            Me.label7.Size = New Size(192, 17)
            Me.label7.TabIndex = 8
            Me.label7.Text = "Diagram Links Style"
            Me.label7.UseCompatibleTextRendering = True
            '
            ' comboLinksStyle
            '
            Me.comboLinksStyle.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.comboLinksStyle.DropDownStyle = ComboBoxStyle.DropDownList
            Me.comboLinksStyle.FormattingEnabled = True
            Me.comboLinksStyle.Location = New Point(201, 3)
            Me.comboLinksStyle.Name = "comboLinksStyle"
            Me.comboLinksStyle.Size = New Size(159, 21)
            Me.comboLinksStyle.TabIndex = 7
            '
            ' MiscellaneousPage
            '
            Me.AutoScaleDimensions = New SizeF(6F, 13F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.comboLinksStyle)
            Me.Name = "MiscellaneousPage"
            Me.Size = New Size(363, 155)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private label7 As Label
        Private comboLinksStyle As ComboBox
    End Class
End Namespace
