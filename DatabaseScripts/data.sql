SET IDENTITY_INSERT [dbo].[Manufacturer] ON
INSERT INTO [dbo].[Manufacturer] ([Id], [BusinessName], [Email]) VALUES (1, N'Tech Products', N'techpro@gmail.com')
INSERT INTO [dbo].[Manufacturer] ([Id], [BusinessName], [Email]) VALUES (2, N'Gadget House', N'gadget@gmail.com')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [ManufacturerId], [Name], [Price], [SalesCommission]) VALUES (1, 2, N'Portable Vacuum', CAST(150.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [ManufacturerId], [Name], [Price], [SalesCommission]) VALUES (2, 1, N'Gameboy ', CAST(200.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [ManufacturerId], [Name], [Price], [SalesCommission]) VALUES (3, 1, N'Paly Station 4', CAST(600.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF

SET IDENTITY_INSERT [dbo].[SalesAgent] ON
INSERT INTO [dbo].[SalesAgent] ([Id], [AgentName], [ContactNumber]) VALUES (1, N'John Walker', N'0218883456')
INSERT INTO [dbo].[SalesAgent] ([Id], [AgentName], [ContactNumber]) VALUES (2, N'Hans Anderson', N'02245567778')
SET IDENTITY_INSERT [dbo].[SalesAgent] OFF


SET IDENTITY_INSERT [dbo].[Sale] ON
INSERT INTO [dbo].[Sale] ([Id], [SalesAgentId], [ProductId], [Quantity]) VALUES (1, 1, 1, 100)
INSERT INTO [dbo].[Sale] ([Id], [SalesAgentId], [ProductId], [Quantity]) VALUES (2, 2, 2, 230)
INSERT INTO [dbo].[Sale] ([Id], [SalesAgentId], [ProductId], [Quantity]) VALUES (3, 2, 3, 400)
SET IDENTITY_INSERT [dbo].[Sale] OFF
