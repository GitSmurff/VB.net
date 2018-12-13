<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim Наименование_предметаLabel As System.Windows.Forms.Label
        Dim Описание_предметаLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentsDataSet = New StudentsDB.StudentsDataSet()
        Me.ПредметыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПредметыTableAdapter = New StudentsDB.StudentsDataSetTableAdapters.ПредметыTableAdapter()
        Me.TableAdapterManager = New StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager()
        Me.ПредметыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ПредметыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Наименование_предметаTextBox = New System.Windows.Forms.TextBox()
        Me.Описание_предметаTextBox = New System.Windows.Forms.TextBox()
        Наименование_предметаLabel = New System.Windows.Forms.Label()
        Описание_предметаLabel = New System.Windows.Forms.Label()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПредметыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПредметыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ПредметыBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Таблица ""Предметы"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПредметыBindingSource
        '
        Me.ПредметыBindingSource.DataMember = "Предметы"
        Me.ПредметыBindingSource.DataSource = Me.StudentsDataSet
        '
        'ПредметыTableAdapter
        '
        Me.ПредметыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ОценкиTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Me.ПредметыTableAdapter
        Me.TableAdapterManager.СпециальностиTableAdapter = Nothing
        Me.TableAdapterManager.СтудентыTableAdapter = Nothing
        '
        'ПредметыBindingNavigator
        '
        Me.ПредметыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ПредметыBindingNavigator.BindingSource = Me.ПредметыBindingSource
        Me.ПредметыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ПредметыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ПредметыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ПредметыBindingNavigatorSaveItem})
        Me.ПредметыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ПредметыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ПредметыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ПредметыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ПредметыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ПредметыBindingNavigator.Name = "ПредметыBindingNavigator"
        Me.ПредметыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ПредметыBindingNavigator.Size = New System.Drawing.Size(447, 25)
        Me.ПредметыBindingNavigator.TabIndex = 2
        Me.ПредметыBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'ПредметыBindingNavigatorSaveItem
        '
        Me.ПредметыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПредметыBindingNavigatorSaveItem.Image = CType(resources.GetObject("ПредметыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ПредметыBindingNavigatorSaveItem.Name = "ПредметыBindingNavigatorSaveItem"
        Me.ПредметыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ПредметыBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Наименование_предметаLabel
        '
        Наименование_предметаLabel.AutoSize = True
        Наименование_предметаLabel.Location = New System.Drawing.Point(39, 117)
        Наименование_предметаLabel.Name = "Наименование_предметаLabel"
        Наименование_предметаLabel.Size = New System.Drawing.Size(138, 13)
        Наименование_предметаLabel.TabIndex = 2
        Наименование_предметаLabel.Text = "Наименование предмета:"
        '
        'Наименование_предметаTextBox
        '
        Me.Наименование_предметаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПредметыBindingSource, "Наименование_предмета", True))
        Me.Наименование_предметаTextBox.Location = New System.Drawing.Point(183, 114)
        Me.Наименование_предметаTextBox.Name = "Наименование_предметаTextBox"
        Me.Наименование_предметаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_предметаTextBox.TabIndex = 3
        '
        'Описание_предметаLabel
        '
        Описание_предметаLabel.AutoSize = True
        Описание_предметаLabel.Location = New System.Drawing.Point(65, 157)
        Описание_предметаLabel.Name = "Описание_предметаLabel"
        Описание_предметаLabel.Size = New System.Drawing.Size(112, 13)
        Описание_предметаLabel.TabIndex = 4
        Описание_предметаLabel.Text = "Описание предмета:"
        '
        'Описание_предметаTextBox
        '
        Me.Описание_предметаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПредметыBindingSource, "Описание_предмета", True))
        Me.Описание_предметаTextBox.Location = New System.Drawing.Point(183, 154)
        Me.Описание_предметаTextBox.Name = "Описание_предметаTextBox"
        Me.Описание_предметаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Описание_предметаTextBox.TabIndex = 5
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 301)
        Me.Controls.Add(Описание_предметаLabel)
        Me.Controls.Add(Me.Описание_предметаTextBox)
        Me.Controls.Add(Наименование_предметаLabel)
        Me.Controls.Add(Me.Наименование_предметаTextBox)
        Me.Controls.Add(Me.ПредметыBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Таблица ""Предметы"""
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПредметыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПредметыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ПредметыBindingNavigator.ResumeLayout(False)
        Me.ПредметыBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StudentsDataSet As StudentsDataSet
    Friend WithEvents ПредметыBindingSource As BindingSource
    Friend WithEvents ПредметыTableAdapter As StudentsDataSetTableAdapters.ПредметыTableAdapter
    Friend WithEvents TableAdapterManager As StudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПредметыBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ПредметыBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Наименование_предметаTextBox As TextBox
    Friend WithEvents Описание_предметаTextBox As TextBox
End Class
