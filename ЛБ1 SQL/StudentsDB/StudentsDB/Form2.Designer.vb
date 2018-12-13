<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim Наименование_специальностиLabel As System.Windows.Forms.Label
        Dim Описание_специальностиLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentsDataSet = New StudentsDB.StudentsDataSet()
        Me.СпециальностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностиTableAdapter = New StudentsDB.StudentsDataSetTableAdapters.СпециальностиTableAdapter()
        Me.TableAdapterManager = New StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager()
        Me.СпециальностиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.СпециальностиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Наименование_специальностиTextBox = New System.Windows.Forms.TextBox()
        Me.Описание_специальностиTextBox = New System.Windows.Forms.TextBox()
        Наименование_специальностиLabel = New System.Windows.Forms.Label()
        Описание_специальностиLabel = New System.Windows.Forms.Label()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.СпециальностиBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Специальности"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СпециальностиBindingSource
        '
        Me.СпециальностиBindingSource.DataMember = "Специальности"
        Me.СпециальностиBindingSource.DataSource = Me.StudentsDataSet
        '
        'СпециальностиTableAdapter
        '
        Me.СпециальностиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ОценкиTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностиTableAdapter = Me.СпециальностиTableAdapter
        Me.TableAdapterManager.СтудентыTableAdapter = Nothing
        '
        'СпециальностиBindingNavigator
        '
        Me.СпециальностиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.СпециальностиBindingNavigator.BindingSource = Me.СпециальностиBindingSource
        Me.СпециальностиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.СпециальностиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.СпециальностиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.СпециальностиBindingNavigatorSaveItem})
        Me.СпециальностиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.СпециальностиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.СпециальностиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.СпециальностиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.СпециальностиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.СпециальностиBindingNavigator.Name = "СпециальностиBindingNavigator"
        Me.СпециальностиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.СпециальностиBindingNavigator.Size = New System.Drawing.Size(369, 25)
        Me.СпециальностиBindingNavigator.TabIndex = 1
        Me.СпециальностиBindingNavigator.Text = "BindingNavigator1"
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
        'СпециальностиBindingNavigatorSaveItem
        '
        Me.СпециальностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СпециальностиBindingNavigatorSaveItem.Image = CType(resources.GetObject("СпециальностиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.СпециальностиBindingNavigatorSaveItem.Name = "СпециальностиBindingNavigatorSaveItem"
        Me.СпециальностиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.СпециальностиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Наименование_специальностиLabel
        '
        Наименование_специальностиLabel.AutoSize = True
        Наименование_специальностиLabel.Location = New System.Drawing.Point(23, 91)
        Наименование_специальностиLabel.Name = "Наименование_специальностиLabel"
        Наименование_специальностиLabel.Size = New System.Drawing.Size(166, 13)
        Наименование_специальностиLabel.TabIndex = 2
        Наименование_специальностиLabel.Text = "Наименование специальности:"
        '
        'Наименование_специальностиTextBox
        '
        Me.Наименование_специальностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СпециальностиBindingSource, "Наименование_специальности", True))
        Me.Наименование_специальностиTextBox.Location = New System.Drawing.Point(195, 84)
        Me.Наименование_специальностиTextBox.Name = "Наименование_специальностиTextBox"
        Me.Наименование_специальностиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_специальностиTextBox.TabIndex = 3
        '
        'Описание_специальностиLabel
        '
        Описание_специальностиLabel.AutoSize = True
        Описание_специальностиLabel.Location = New System.Drawing.Point(49, 131)
        Описание_специальностиLabel.Name = "Описание_специальностиLabel"
        Описание_специальностиLabel.Size = New System.Drawing.Size(140, 13)
        Описание_специальностиLabel.TabIndex = 4
        Описание_специальностиLabel.Text = "Описание специальности:"
        '
        'Описание_специальностиTextBox
        '
        Me.Описание_специальностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СпециальностиBindingSource, "Описание_специальности", True))
        Me.Описание_специальностиTextBox.Location = New System.Drawing.Point(195, 128)
        Me.Описание_специальностиTextBox.Name = "Описание_специальностиTextBox"
        Me.Описание_специальностиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Описание_специальностиTextBox.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 341)
        Me.Controls.Add(Описание_специальностиLabel)
        Me.Controls.Add(Me.Описание_специальностиTextBox)
        Me.Controls.Add(Наименование_специальностиLabel)
        Me.Controls.Add(Me.Наименование_специальностиTextBox)
        Me.Controls.Add(Me.СпециальностиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Таблица ""Специальности"""
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.СпециальностиBindingNavigator.ResumeLayout(False)
        Me.СпециальностиBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StudentsDataSet As StudentsDataSet
    Friend WithEvents СпециальностиBindingSource As BindingSource
    Friend WithEvents СпециальностиTableAdapter As StudentsDataSetTableAdapters.СпециальностиTableAdapter
    Friend WithEvents TableAdapterManager As StudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СпециальностиBindingNavigator As BindingNavigator
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
    Friend WithEvents СпециальностиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Наименование_специальностиTextBox As TextBox
    Friend WithEvents Описание_специальностиTextBox As TextBox
End Class
