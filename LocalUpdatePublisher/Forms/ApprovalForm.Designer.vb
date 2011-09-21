﻿' Copyright (c) <2010> <Bryan R. Dam>
' Released under the MIT license as found in LICENSE.txt
'
' Created by SharpDevelop.
' User: Bryan Dam
' Date: 11/6/2009
' Time: 2:55 PM

Partial Class ApprovalForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApprovalForm))
		Me.lblInfo = New System.Windows.Forms.Label
		Me.dgvApprovals = New System.Windows.Forms.DataGridView
		Me.ComputerGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Approval = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.cntxtMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.approveForInstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.approveForRemovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.notApprovedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.Deadline = New LocalUpdatePublisher.CalendarColumn
		Me.CreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ApprovalAction = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.TargetGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.btnOK = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.lblUninstallable = New System.Windows.Forms.Label
		Me.btnReload = New System.Windows.Forms.Button
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
		CType(Me.dgvApprovals,System.ComponentModel.ISupportInitialize).BeginInit
		Me.cntxtMenuStrip.SuspendLayout
		Me.tableLayoutPanel1.SuspendLayout
		Me.SuspendLayout
		'
		'lblInfo
		'
		Me.tableLayoutPanel1.SetColumnSpan(Me.lblInfo, 4)
		resources.ApplyResources(Me.lblInfo, "lblInfo")
		Me.lblInfo.Name = "lblInfo"
		'
		'dgvApprovals
		'
		Me.dgvApprovals.AllowUserToAddRows = false
		Me.dgvApprovals.AllowUserToDeleteRows = false
		Me.dgvApprovals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvApprovals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ComputerGroup, Me.Approval, Me.Deadline, Me.CreationDate, Me.ApprovalAction, Me.TargetGroup})
		Me.tableLayoutPanel1.SetColumnSpan(Me.dgvApprovals, 4)
		resources.ApplyResources(Me.dgvApprovals, "dgvApprovals")
		Me.dgvApprovals.Name = "dgvApprovals"
		Me.dgvApprovals.RowHeadersVisible = false
		AddHandler Me.dgvApprovals.CellMouseDown, AddressOf Me.DtaGridViewCellMouseDown
		'
		'ComputerGroup
		'
		Me.ComputerGroup.FillWeight = 142.2902!
		resources.ApplyResources(Me.ComputerGroup, "ComputerGroup")
		Me.ComputerGroup.Name = "ComputerGroup"
		Me.ComputerGroup.ReadOnly = true
		'
		'Approval
		'
		Me.Approval.ContextMenuStrip = Me.cntxtMenuStrip
		Me.Approval.FillWeight = 96.79607!
		resources.ApplyResources(Me.Approval, "Approval")
		Me.Approval.Name = "Approval"
		Me.Approval.ReadOnly = true
		Me.Approval.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Approval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		'
		'cntxtMenuStrip
		'
		Me.cntxtMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.approveForInstallToolStripMenuItem, Me.approveForRemovalToolStripMenuItem, Me.notApprovedToolStripMenuItem})
		Me.cntxtMenuStrip.Name = "contextMenuStrip"
		resources.ApplyResources(Me.cntxtMenuStrip, "cntxtMenuStrip")
		'
		'approveForInstallToolStripMenuItem
		'
		Me.approveForInstallToolStripMenuItem.Name = "approveForInstallToolStripMenuItem"
		resources.ApplyResources(Me.approveForInstallToolStripMenuItem, "approveForInstallToolStripMenuItem")
		AddHandler Me.approveForInstallToolStripMenuItem.Click, AddressOf Me.ApproveForInstallToolStripMenuItemClick
		'
		'approveForRemovalToolStripMenuItem
		'
		Me.approveForRemovalToolStripMenuItem.Name = "approveForRemovalToolStripMenuItem"
		resources.ApplyResources(Me.approveForRemovalToolStripMenuItem, "approveForRemovalToolStripMenuItem")
		AddHandler Me.approveForRemovalToolStripMenuItem.Click, AddressOf Me.ApproveForRemovalToolStripMenuItemClick
		'
		'notApprovedToolStripMenuItem
		'
		Me.notApprovedToolStripMenuItem.Name = "notApprovedToolStripMenuItem"
		resources.ApplyResources(Me.notApprovedToolStripMenuItem, "notApprovedToolStripMenuItem")
		AddHandler Me.notApprovedToolStripMenuItem.Click, AddressOf Me.NotApprovedToolStripMenuItemClick
		'
		'Deadline
		'
		Me.Deadline.FillWeight = 60.9137!
		resources.ApplyResources(Me.Deadline, "Deadline")
		Me.Deadline.Name = "Deadline"
		'
		'CreationDate
		'
		Me.CreationDate.FillWeight = 60.9137!
		resources.ApplyResources(Me.CreationDate, "CreationDate")
		Me.CreationDate.Name = "CreationDate"
		Me.CreationDate.ReadOnly = true
		'
		'ApprovalAction
		'
		resources.ApplyResources(Me.ApprovalAction, "ApprovalAction")
		Me.ApprovalAction.Name = "ApprovalAction"
		Me.ApprovalAction.ReadOnly = true
		'
		'TargetGroup
		'
		resources.ApplyResources(Me.TargetGroup, "TargetGroup")
		Me.TargetGroup.Name = "TargetGroup"
		Me.TargetGroup.ReadOnly = true
		'
		'btnOK
		'
		resources.ApplyResources(Me.btnOK, "btnOK")
		Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOK.Name = "btnOK"
		Me.btnOK.UseVisualStyleBackColor = true
		AddHandler Me.btnOK.Click, AddressOf Me.btnOKClick
		'
		'btnCancel
		'
		resources.ApplyResources(Me.btnCancel, "btnCancel")
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.UseVisualStyleBackColor = true
		'
		'lblUninstallable
		'
		Me.tableLayoutPanel1.SetColumnSpan(Me.lblUninstallable, 4)
		resources.ApplyResources(Me.lblUninstallable, "lblUninstallable")
		Me.lblUninstallable.Name = "lblUninstallable"
		'
		'btnReload
		'
		resources.ApplyResources(Me.btnReload, "btnReload")
		Me.btnReload.Name = "btnReload"
		Me.btnReload.UseVisualStyleBackColor = true
		AddHandler Me.btnReload.Click, AddressOf Me.BtnReloadClick
		'
		'tableLayoutPanel1
		'
		resources.ApplyResources(Me.tableLayoutPanel1, "tableLayoutPanel1")
		Me.tableLayoutPanel1.Controls.Add(Me.btnCancel, 3, 3)
		Me.tableLayoutPanel1.Controls.Add(Me.btnOK, 2, 3)
		Me.tableLayoutPanel1.Controls.Add(Me.btnReload, 0, 3)
		Me.tableLayoutPanel1.Controls.Add(Me.dgvApprovals, 0, 1)
		Me.tableLayoutPanel1.Controls.Add(Me.lblInfo, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.lblUninstallable, 0, 2)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		'
		'ApprovalForm
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.MinimizeBox = false
		Me.Name = "ApprovalForm"
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		AddHandler FormClosed, AddressOf Me.UpdateApprovalFormFormClosed
		CType(Me.dgvApprovals,System.ComponentModel.ISupportInitialize).EndInit
		Me.cntxtMenuStrip.ResumeLayout(false)
		Me.tableLayoutPanel1.ResumeLayout(false)
		Me.tableLayoutPanel1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private Deadline As LocalUpdatePublisher.CalendarColumn
	Private CreationDate As System.Windows.Forms.DataGridViewTextBoxColumn
	Private btnOK As System.Windows.Forms.Button
	Private btnReload As System.Windows.Forms.Button
	Private dgvApprovals As System.Windows.Forms.DataGridView
	Private TargetGroup As System.Windows.Forms.DataGridViewTextBoxColumn
	Private ApprovalAction As System.Windows.Forms.DataGridViewTextBoxColumn
	Private notApprovedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private approveForRemovalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private approveForInstallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private Approval As System.Windows.Forms.DataGridViewTextBoxColumn
	Private ComputerGroup As System.Windows.Forms.DataGridViewTextBoxColumn
	Private lblUninstallable As System.Windows.Forms.Label
	Private cntxtMenuStrip As System.Windows.Forms.ContextMenuStrip
	Private btnCancel As System.Windows.Forms.Button
	Private lblInfo As System.Windows.Forms.Label
End Class
