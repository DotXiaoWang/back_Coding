/*
 Navicat Premium Data Transfer

 Source Server         : sqlserver
 Source Server Type    : SQL Server
 Source Server Version : 11003000
 Source Host           : 192.168.31.125:1443
 Source Catalog        : studentInfo
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 11003000
 File Encoding         : 65001

 Date: 29/11/2022 10:31:27
*/


-- ----------------------------
-- Table structure for infoStu
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[infoStu]') AND type IN ('U'))
	DROP TABLE [dbo].[infoStu]
GO

CREATE TABLE [dbo].[infoStu] (
  [username] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [password1] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [password2] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [xm] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [age] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [sex] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [grade] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[infoStu] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of infoStu
-- ----------------------------
INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin2', N'admin2', N'admin2', N'小亮', N'23', N'男', N'2022')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'11', N'11', N'11', N'11', N'11', N'男', N'2021级专升本二班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin3', N'admin3', N'admin3', N'小王', N'22', N'男', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin4', N'admin4', N'admin4', N'小张', N'21', N'女', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin5', N'admin5', N'admin5', N'admin3', N'24', N'男', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin6', N'admin6', N'admin6', N'admin4', N'21', N'女', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin7', N'admin7', N'admin7', N'admin5', N'22', N'男', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin8', N'admin8', N'admin8', N'admin6', N'23', N'男', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin9', N'admin9', N'admin9', N'admin7', N'25', N'男', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'admin10', N'admin10', N'admin10', N'admin8', N'26', N'男', N'2021级专升本一班')
GO

INSERT INTO [dbo].[infoStu] ([username], [password1], [password2], [xm], [age], [sex], [grade]) VALUES (N'11', N'11', N'', N'', N'', N'男', N'')
GO

