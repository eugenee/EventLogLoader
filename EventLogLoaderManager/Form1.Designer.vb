﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView = New System.Windows.Forms.ListView()
        Me.InfobaseName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfobaseGUID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfobaseDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IBEvLogSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfobaseLogPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ESServerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StartAt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ConnectionStringBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ESIndexNameTextBox = New System.Windows.Forms.TextBox()
        Me.DBType = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonAddPath = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RepeatTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UseSynonymsForFieldsNamesCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelIndexNameExample = New System.Windows.Forms.Label()
        Me.CheckBoxSplitIndexByPeriods = New System.Windows.Forms.CheckBox()
        Me.ComboBoxESIndexPostfix = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView
        '
        Me.ListView.CheckBoxes = True
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.InfobaseName, Me.InfobaseGUID, Me.InfobaseDescription, Me.IBEvLogSize, Me.InfobaseLogPath, Me.ESServerName, Me.StartAt})
        Me.ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(4, 25)
        Me.ListView.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(995, 335)
        Me.ListView.TabIndex = 1
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'InfobaseName
        '
        Me.InfobaseName.Text = "Имя базы"
        Me.InfobaseName.Width = 200
        '
        'InfobaseGUID
        '
        Me.InfobaseGUID.Text = "Идентификатор базы"
        Me.InfobaseGUID.Width = 0
        '
        'InfobaseDescription
        '
        Me.InfobaseDescription.DisplayIndex = 3
        Me.InfobaseDescription.Text = "Описание"
        Me.InfobaseDescription.Width = 225
        '
        'IBEvLogSize
        '
        Me.IBEvLogSize.DisplayIndex = 4
        Me.IBEvLogSize.Text = "Размер ЖР (Мб)"
        Me.IBEvLogSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IBEvLogSize.Width = 129
        '
        'InfobaseLogPath
        '
        Me.InfobaseLogPath.DisplayIndex = 5
        Me.InfobaseLogPath.Text = "Каталог ЖР"
        Me.InfobaseLogPath.Width = 300
        '
        'ESServerName
        '
        Me.ESServerName.DisplayIndex = 2
        Me.ESServerName.Text = "Имя сервера для ES"
        Me.ESServerName.Width = 180
        '
        'StartAt
        '
        Me.StartAt.Text = "Начальная дата"
        Me.StartAt.Width = 150
        '
        'ConnectionStringBox
        '
        Me.ConnectionStringBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectionStringBox.Location = New System.Drawing.Point(164, 30)
        Me.ConnectionStringBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ConnectionStringBox.Name = "ConnectionStringBox"
        Me.ConnectionStringBox.Size = New System.Drawing.Size(701, 22)
        Me.ConnectionStringBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Строка соединения с базой данных для записи событий ЖР"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(875, 30)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Проверить"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ESIndexNameTextBox
        '
        Me.ESIndexNameTextBox.Location = New System.Drawing.Point(143, 26)
        Me.ESIndexNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ESIndexNameTextBox.Name = "ESIndexNameTextBox"
        Me.ESIndexNameTextBox.Size = New System.Drawing.Size(224, 28)
        Me.ESIndexNameTextBox.TabIndex = 9
        '
        'DBType
        '
        Me.DBType.FormattingEnabled = True
        Me.DBType.Items.AddRange(New Object() {"MS SQL Server", "MySQL", "ElasticSearch"})
        Me.DBType.Location = New System.Drawing.Point(7, 30)
        Me.DBType.Margin = New System.Windows.Forms.Padding(4)
        Me.DBType.Name = "DBType"
        Me.DBType.Size = New System.Drawing.Size(148, 24)
        Me.DBType.TabIndex = 8
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Image = Global.EventLogLoaderManager.My.Resources.Resources.info
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(852, 561)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(164, 59)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "О программе"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListView)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(5, 190)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 364)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Обнаруженные информационные базы 1С"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(5, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(464, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Интервал между циклами чтения событий из ЖР (секунд)"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.EventLogLoaderManager.My.Resources.Resources.save_all
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(627, 561)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Сохранить параметры"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Image = Global.EventLogLoaderManager.My.Resources.Resources.edit_delete_5986
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(433, 561)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 58)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Удалить службу"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonAddPath
        '
        Me.ButtonAddPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddPath.Image = Global.EventLogLoaderManager.My.Resources.Resources.edit_add_3860
        Me.ButtonAddPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAddPath.Location = New System.Drawing.Point(5, 561)
        Me.ButtonAddPath.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAddPath.Name = "ButtonAddPath"
        Me.ButtonAddPath.Size = New System.Drawing.Size(216, 58)
        Me.ButtonAddPath.TabIndex = 0
        Me.ButtonAddPath.Text = "Добавить путь вручную"
        Me.ButtonAddPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAddPath.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.EventLogLoaderManager.My.Resources.Resources.edit_add_3860
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(229, 561)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 58)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Установить службу"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RepeatTime
        '
        Me.RepeatTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RepeatTime.Location = New System.Drawing.Point(599, 60)
        Me.RepeatTime.Margin = New System.Windows.Forms.Padding(4)
        Me.RepeatTime.Name = "RepeatTime"
        Me.RepeatTime.Size = New System.Drawing.Size(207, 22)
        Me.RepeatTime.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 631)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Описание и страница для обратной связи:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(304, 631)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(209, 17)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://infostart.ru/public/182820/"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(304, 652)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(334, 17)
        Me.LinkLabel3.TabIndex = 21
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "https://github.com/alekseybochkov/EventLogLoader"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 652)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Исходные коды (по GPL лицензии):"
        '
        'UseSynonymsForFieldsNamesCheckBox
        '
        Me.UseSynonymsForFieldsNamesCheckBox.AutoSize = True
        Me.UseSynonymsForFieldsNamesCheckBox.ForeColor = System.Drawing.Color.Black
        Me.UseSynonymsForFieldsNamesCheckBox.Location = New System.Drawing.Point(17, 62)
        Me.UseSynonymsForFieldsNamesCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UseSynonymsForFieldsNamesCheckBox.Name = "UseSynonymsForFieldsNamesCheckBox"
        Me.UseSynonymsForFieldsNamesCheckBox.Size = New System.Drawing.Size(287, 25)
        Me.UseSynonymsForFieldsNamesCheckBox.TabIndex = 23
        Me.UseSynonymsForFieldsNamesCheckBox.Text = "Использовать свои имена полей"
        Me.UseSynonymsForFieldsNamesCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 27)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Имя индекса"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LabelIndexNameExample)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSplitIndexByPeriods)
        Me.GroupBox2.Controls.Add(Me.ComboBoxESIndexPostfix)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ESIndexNameTextBox)
        Me.GroupBox2.Controls.Add(Me.UseSynonymsForFieldsNamesCheckBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(8, 86)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 96)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Параметры для ElasticSearch"
        '
        'LabelIndexNameExample
        '
        Me.LabelIndexNameExample.AutoSize = True
        Me.LabelIndexNameExample.Location = New System.Drawing.Point(377, 63)
        Me.LabelIndexNameExample.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIndexNameExample.Name = "LabelIndexNameExample"
        Me.LabelIndexNameExample.Size = New System.Drawing.Size(203, 21)
        Me.LabelIndexNameExample.TabIndex = 28
        Me.LabelIndexNameExample.Text = "Пример имени индекса: "
        '
        'CheckBoxSplitIndexByPeriods
        '
        Me.CheckBoxSplitIndexByPeriods.AutoSize = True
        Me.CheckBoxSplitIndexByPeriods.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxSplitIndexByPeriods.Location = New System.Drawing.Point(377, 28)
        Me.CheckBoxSplitIndexByPeriods.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxSplitIndexByPeriods.Name = "CheckBoxSplitIndexByPeriods"
        Me.CheckBoxSplitIndexByPeriods.Size = New System.Drawing.Size(393, 25)
        Me.CheckBoxSplitIndexByPeriods.TabIndex = 27
        Me.CheckBoxSplitIndexByPeriods.Text = "Разделять индекс по периодам с постфиксом:"
        Me.CheckBoxSplitIndexByPeriods.UseVisualStyleBackColor = True
        '
        'ComboBoxESIndexPostfix
        '
        Me.ComboBoxESIndexPostfix.FormattingEnabled = True
        Me.ComboBoxESIndexPostfix.Items.AddRange(New Object() {"yyyy", "yyyyMM", "yyyyMMdd", "yyyyMMddHH"})
        Me.ComboBoxESIndexPostfix.Location = New System.Drawing.Point(824, 27)
        Me.ComboBoxESIndexPostfix.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxESIndexPostfix.Name = "ComboBoxESIndexPostfix"
        Me.ComboBoxESIndexPostfix.Size = New System.Drawing.Size(139, 29)
        Me.ComboBoxESIndexPostfix.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 673)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DBType)
        Me.Controls.Add(Me.ConnectionStringBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.RepeatTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAddPath)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents InfobaseName As System.Windows.Forms.ColumnHeader
    Friend WithEvents InfobaseGUID As System.Windows.Forms.ColumnHeader
    Friend WithEvents InfobaseDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents IBEvLogSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ConnectionStringBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RepeatTime As System.Windows.Forms.TextBox
    Friend WithEvents InfobaseLogPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents DBType As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAddPath As System.Windows.Forms.Button
    Friend WithEvents ESIndexNameTextBox As TextBox
    Friend WithEvents ESServerName As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents UseSynonymsForFieldsNamesCheckBox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StartAt As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelIndexNameExample As Label
    Friend WithEvents CheckBoxSplitIndexByPeriods As CheckBox
    Friend WithEvents ComboBoxESIndexPostfix As ComboBox
End Class
