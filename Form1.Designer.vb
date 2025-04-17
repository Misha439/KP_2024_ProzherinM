<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KP_2024_ProzherinMDataSet = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSet()
        Me.APPLICATION_WORKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APPLICATION_WORKERTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.APPLICATION_WORKERTableAdapter()
        Me.TableAdapterManager = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.TableAdapterManager()
        Me.CATEGORY_OF_WORKSTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.CATEGORY_OF_WORKSTableAdapter()
        Me.CLIENTTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.CLIENTTableAdapter()
        Me.CONTROLLERTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.CONTROLLERTableAdapter()
        Me.PERFORMANCE_ASSESSMENTTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.PERFORMANCE_ASSESSMENTTableAdapter()
        Me.POSTSTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.POSTSTableAdapter()
        Me.SERVICE_REQUESTTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.SERVICE_REQUESTTableAdapter()
        Me.STATUSTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.STATUSTableAdapter()
        Me.TYPE_OF_WORKTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.TYPE_OF_WORKTableAdapter()
        Me.WORKERSTableAdapter = New KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.WORKERSTableAdapter()
        Me.CATEGORY_OF_WORKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTROLLERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERFORMANCE_ASSESSMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POSTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERVICE_REQUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPE_OF_WORKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientZayavkaLV = New System.Windows.Forms.ListView()
        CType(Me.KP_2024_ProzherinMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APPLICATION_WORKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORY_OF_WORKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTROLLERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERFORMANCE_ASSESSMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERVICE_REQUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPE_OF_WORKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KP_2024_ProzherinMDataSet
        '
        Me.KP_2024_ProzherinMDataSet.DataSetName = "KP_2024_ProzherinMDataSet"
        Me.KP_2024_ProzherinMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APPLICATION_WORKERBindingSource
        '
        Me.APPLICATION_WORKERBindingSource.DataMember = "APPLICATION_WORKER"
        Me.APPLICATION_WORKERBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'APPLICATION_WORKERTableAdapter
        '
        Me.APPLICATION_WORKERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APPLICATION_WORKERTableAdapter = Me.APPLICATION_WORKERTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_OF_WORKSTableAdapter = Me.CATEGORY_OF_WORKSTableAdapter
        Me.TableAdapterManager.CLIENTTableAdapter = Me.CLIENTTableAdapter
        Me.TableAdapterManager.CONTROLLERTableAdapter = Me.CONTROLLERTableAdapter
        Me.TableAdapterManager.PERFORMANCE_ASSESSMENTTableAdapter = Me.PERFORMANCE_ASSESSMENTTableAdapter
        Me.TableAdapterManager.POSTSTableAdapter = Me.POSTSTableAdapter
        Me.TableAdapterManager.SERVICE_REQUESTTableAdapter = Me.SERVICE_REQUESTTableAdapter
        Me.TableAdapterManager.STATUSTableAdapter = Me.STATUSTableAdapter
        Me.TableAdapterManager.TYPE_OF_WORKTableAdapter = Me.TYPE_OF_WORKTableAdapter
        Me.TableAdapterManager.UpdateOrder = KP_2024_ProzherinM.KP_2024_ProzherinMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WORKERSTableAdapter = Me.WORKERSTableAdapter
        '
        'CATEGORY_OF_WORKSTableAdapter
        '
        Me.CATEGORY_OF_WORKSTableAdapter.ClearBeforeFill = True
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'CONTROLLERTableAdapter
        '
        Me.CONTROLLERTableAdapter.ClearBeforeFill = True
        '
        'PERFORMANCE_ASSESSMENTTableAdapter
        '
        Me.PERFORMANCE_ASSESSMENTTableAdapter.ClearBeforeFill = True
        '
        'POSTSTableAdapter
        '
        Me.POSTSTableAdapter.ClearBeforeFill = True
        '
        'SERVICE_REQUESTTableAdapter
        '
        Me.SERVICE_REQUESTTableAdapter.ClearBeforeFill = True
        '
        'STATUSTableAdapter
        '
        Me.STATUSTableAdapter.ClearBeforeFill = True
        '
        'TYPE_OF_WORKTableAdapter
        '
        Me.TYPE_OF_WORKTableAdapter.ClearBeforeFill = True
        '
        'WORKERSTableAdapter
        '
        Me.WORKERSTableAdapter.ClearBeforeFill = True
        '
        'CATEGORY_OF_WORKSBindingSource
        '
        Me.CATEGORY_OF_WORKSBindingSource.DataMember = "CATEGORY_OF_WORKS"
        Me.CATEGORY_OF_WORKSBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'CONTROLLERBindingSource
        '
        Me.CONTROLLERBindingSource.DataMember = "CONTROLLER"
        Me.CONTROLLERBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'PERFORMANCE_ASSESSMENTBindingSource
        '
        Me.PERFORMANCE_ASSESSMENTBindingSource.DataMember = "PERFORMANCE_ASSESSMENT"
        Me.PERFORMANCE_ASSESSMENTBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'POSTSBindingSource
        '
        Me.POSTSBindingSource.DataMember = "POSTS"
        Me.POSTSBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'SERVICE_REQUESTBindingSource
        '
        Me.SERVICE_REQUESTBindingSource.DataMember = "SERVICE_REQUEST"
        Me.SERVICE_REQUESTBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'STATUSBindingSource
        '
        Me.STATUSBindingSource.DataMember = "STATUS"
        Me.STATUSBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'TYPE_OF_WORKBindingSource
        '
        Me.TYPE_OF_WORKBindingSource.DataMember = "TYPE_OF_WORK"
        Me.TYPE_OF_WORKBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'WORKERSBindingSource
        '
        Me.WORKERSBindingSource.DataMember = "WORKERS"
        Me.WORKERSBindingSource.DataSource = Me.KP_2024_ProzherinMDataSet
        '
        'ClientZayavkaLV
        '
        Me.ClientZayavkaLV.AllowColumnReorder = True
        Me.ClientZayavkaLV.FullRowSelect = True
        Me.ClientZayavkaLV.GridLines = True
        Me.ClientZayavkaLV.HideSelection = False
        Me.ClientZayavkaLV.Location = New System.Drawing.Point(29, 22)
        Me.ClientZayavkaLV.Name = "ClientZayavkaLV"
        Me.ClientZayavkaLV.Size = New System.Drawing.Size(1049, 278)
        Me.ClientZayavkaLV.TabIndex = 0
        Me.ClientZayavkaLV.UseCompatibleStateImageBehavior = False
        Me.ClientZayavkaLV.View = System.Windows.Forms.View.Details
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 328)
        Me.Controls.Add(Me.ClientZayavkaLV)
        Me.Name = "Form1"
        Me.Text = "Просмотр заявков клиента"
        CType(Me.KP_2024_ProzherinMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APPLICATION_WORKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORY_OF_WORKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTROLLERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERFORMANCE_ASSESSMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERVICE_REQUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPE_OF_WORKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KP_2024_ProzherinMDataSet As KP_2024_ProzherinMDataSet
    Friend WithEvents APPLICATION_WORKERBindingSource As BindingSource
    Friend WithEvents APPLICATION_WORKERTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.APPLICATION_WORKERTableAdapter
    Friend WithEvents TableAdapterManager As KP_2024_ProzherinMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CATEGORY_OF_WORKSTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.CATEGORY_OF_WORKSTableAdapter
    Friend WithEvents CATEGORY_OF_WORKSBindingSource As BindingSource
    Friend WithEvents CLIENTTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.CLIENTTableAdapter
    Friend WithEvents CLIENTBindingSource As BindingSource
    Friend WithEvents CONTROLLERTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.CONTROLLERTableAdapter
    Friend WithEvents CONTROLLERBindingSource As BindingSource
    Friend WithEvents PERFORMANCE_ASSESSMENTTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.PERFORMANCE_ASSESSMENTTableAdapter
    Friend WithEvents PERFORMANCE_ASSESSMENTBindingSource As BindingSource
    Friend WithEvents POSTSTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.POSTSTableAdapter
    Friend WithEvents POSTSBindingSource As BindingSource
    Friend WithEvents SERVICE_REQUESTTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.SERVICE_REQUESTTableAdapter
    Friend WithEvents SERVICE_REQUESTBindingSource As BindingSource
    Friend WithEvents STATUSTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.STATUSTableAdapter
    Friend WithEvents STATUSBindingSource As BindingSource
    Friend WithEvents TYPE_OF_WORKTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.TYPE_OF_WORKTableAdapter
    Friend WithEvents TYPE_OF_WORKBindingSource As BindingSource
    Friend WithEvents WORKERSTableAdapter As KP_2024_ProzherinMDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents WORKERSBindingSource As BindingSource
    Friend WithEvents ClientZayavkaLV As ListView
End Class
