﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Db_scepDataSet = New scep.db_scepDataSet()
        Me.OrderedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderedTableAdapter = New scep.db_scepDataSetTableAdapters.orderedTableAdapter()
        CType(Me.Db_scepDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Db_scepDataSet
        '
        Me.Db_scepDataSet.DataSetName = "db_scepDataSet"
        Me.Db_scepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderedBindingSource
        '
        Me.OrderedBindingSource.DataMember = "ordered"
        Me.OrderedBindingSource.DataSource = Me.Db_scepDataSet
        '
        'OrderedTableAdapter
        '
        Me.OrderedTableAdapter.ClearBeforeFill = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_login"
        Me.Text = "frm_login"
        CType(Me.Db_scepDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Db_scepDataSet As db_scepDataSet
    Friend WithEvents OrderedBindingSource As Windows.Forms.BindingSource
    Friend WithEvents OrderedTableAdapter As db_scepDataSetTableAdapters.orderedTableAdapter
End Class
