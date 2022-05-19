Namespace DxSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnAllowUpdate = New System.Windows.Forms.Button()
            Me.btnRestore = New System.Windows.Forms.Button()
            Me.pivotGrid1 = New DxSample.MyPivotGrid()
            CType((Me.pivotGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnSave
            ' 
            Me.btnSave.Location = New System.Drawing.Point(12, 12)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 23)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = True
            AddHandler Me.btnSave.Click, New System.EventHandler(AddressOf Me.btnSave_Click)
            ' 
            ' btnAllowUpdate
            ' 
            Me.btnAllowUpdate.Location = New System.Drawing.Point(93, 12)
            Me.btnAllowUpdate.Name = "btnAllowUpdate"
            Me.btnAllowUpdate.Size = New System.Drawing.Size(75, 23)
            Me.btnAllowUpdate.TabIndex = 2
            Me.btnAllowUpdate.Text = "Update"
            Me.btnAllowUpdate.UseVisualStyleBackColor = True
            AddHandler Me.btnAllowUpdate.Click, New System.EventHandler(AddressOf Me.btnUpdate_Click)
            ' 
            ' btnRestore
            ' 
            Me.btnRestore.Location = New System.Drawing.Point(174, 12)
            Me.btnRestore.Name = "btnRestore"
            Me.btnRestore.Size = New System.Drawing.Size(75, 23)
            Me.btnRestore.TabIndex = 3
            Me.btnRestore.Text = "Restore"
            Me.btnRestore.UseVisualStyleBackColor = True
            AddHandler Me.btnRestore.Click, New System.EventHandler(AddressOf Me.btnRestore_Click)
            ' 
            ' pivotGrid1
            ' 
            Me.pivotGrid1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pivotGrid1.Location = New System.Drawing.Point(12, 41)
            Me.pivotGrid1.Name = "pivotGrid1"
            Me.pivotGrid1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGrid1.Size = New System.Drawing.Size(698, 359)
            Me.pivotGrid1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(722, 412)
            Me.Controls.Add(Me.btnRestore)
            Me.Controls.Add(Me.btnAllowUpdate)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.pivotGrid1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.pivotGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGrid1 As DxSample.MyPivotGrid

        Private btnSave As System.Windows.Forms.Button

        Private btnAllowUpdate As System.Windows.Forms.Button

        Private btnRestore As System.Windows.Forms.Button
    End Class
End Namespace
