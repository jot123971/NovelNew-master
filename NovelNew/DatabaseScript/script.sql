SET IDENTITY_INSERT [dbo].[Author] ON
INSERT INTO [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (1, N'nanak singh', N'living', NULL)
INSERT INTO [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (2, N'sion abel', N'whales', NULL)
INSERT INTO [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (3, N'jhon abbot', N'norway', NULL)
INSERT INTO [dbo].[Author] ([AuthorId], [Name], [Bio], [NovelId]) VALUES (4, N'george', N'ottoman', NULL)
SET IDENTITY_INSERT [dbo].[Author] OFF
SET IDENTITY_INSERT [dbo].[Genre] ON
INSERT INTO [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (1, N'action and adventure')
INSERT INTO [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (2, N'rock music')
INSERT INTO [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (3, N'classics')
INSERT INTO [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (4, N'comic book')
INSERT INTO [dbo].[Genre] ([GenreId], [GenreOfNovel]) VALUES (5, N'mystery')
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[Novel] ON
INSERT INTO [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (1, N'comic', N'2021-01-28 07:35:00', 1, N'very nice', 2)
INSERT INTO [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (2, N'romatic', N'2021-01-07 07:36:00', 1, N'interesting', 2)
INSERT INTO [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (3, N'classic', N'2021-01-13 07:37:00', 0, N'good', 3)
INSERT INTO [dbo].[Novel] ([NovelId], [Title], [Review], [IsFamous], [Comments], [GenreId]) VALUES (4, N'mystery', N'2021-01-15 07:38:00', 0, N'very interesting', 5)
SET IDENTITY_INSERT [dbo].[Novel] OFF
SET IDENTITY_INSERT [dbo].[NovelAuthor] ON
INSERT INTO [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId], [AutherAuthorId]) VALUES (1, 3, 3, NULL)
INSERT INTO [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId], [AutherAuthorId]) VALUES (2, 2, 3, NULL)
INSERT INTO [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId], [AutherAuthorId]) VALUES (3, 4, 2, NULL)
INSERT INTO [dbo].[NovelAuthor] ([NovelAuthorId], [AuthorId], [NovelId], [AutherAuthorId]) VALUES (4, 2, 1, NULL)
SET IDENTITY_INSERT [dbo].[NovelAuthor] OFF
