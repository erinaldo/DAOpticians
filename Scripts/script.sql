USE [DAOpticians]
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_Delete]    Script Date: 11/24/2012 11:40:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[HearingQuotation_Delete]
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_GetAll]    Script Date: 11/24/2012 11:40:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_GetAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[HearingQuotation_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_GetByID]    Script Date: 11/24/2012 11:40:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_GetByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[HearingQuotation_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_Insert]    Script Date: 11/24/2012 11:40:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[HearingQuotation_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Prescription_GetByall]    Script Date: 11/24/2012 11:40:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Prescription_GetByall]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Prescription_GetByall]
GO
/****** Object:  Table [dbo].[tblHearingQuotation]    Script Date: 11/24/2012 11:39:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHearingQuotation]') AND type in (N'U'))
DROP TABLE [dbo].[tblHearingQuotation]
GO
/****** Object:  Table [dbo].[tblHearingQuotation]    Script Date: 11/24/2012 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHearingQuotation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHearingQuotation](
	[HearingQuotationID] [bigint] IDENTITY(1,1) NOT NULL,
	[QuotationNo] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[Address3] [nvarchar](100) NULL,
	[Age] [int] NULL,
	[Date] [datetime] NULL,
	[Occupation] [nvarchar](50) NULL,
	[Audiogram] [nvarchar](50) NULL,
	[BrandModal] [nvarchar](50) NULL,
	[BrandModalLeft] [nvarchar](50) NULL,
	[BrandModalRight] [nvarchar](50) NULL,
	[EarMold] [nvarchar](50) NULL,
	[EarMoldLeft] [nvarchar](50) NULL,
	[EarMoldRight] [nvarchar](50) NULL,
	[OtherAccessories] [nvarchar](50) NULL,
	[Gaurantee] [nvarchar](50) NULL,
	[PTALeft] [nvarchar](50) NULL,
	[PTARight] [nvarchar](50) NULL,
	[Total] [money] NULL,
	[Valid Days] [nvarchar](10) NULL,
	[Remarks] [ntext] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblHearingQuotation] PRIMARY KEY CLUSTERED 
(
	[HearingQuotationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[Prescription_GetByall]    Script Date: 11/24/2012 11:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Prescription_GetByall]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Prescription_GetByall]
	
AS 
SELECT     PrescriptionID 
FROM       tblPrescription 
order by   PrescriptionID DESC' 
END
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_Insert]    Script Date: 11/24/2012 11:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[HearingQuotation_Insert]
	
	
	
	@HearingQuotationID bigint,
	@QuotationNo NVARCHAR(20), 
	@CustomerName NVARCHAR(100)	, 
	@Address1 NVARCHAR(100), 
	@Address2 NVARCHAR(100), 
	@Address3 NVARCHAR(100), 
	@Age INT, 
	@Date DATETIME, 
	@Occupation NVARCHAR(50), 
		
	@Audiogram	nvarchar(50),
	@BrandModal nvarchar(50),	
	@BrandModalLeft	nvarchar(50),	
	@BrandModalRight	nvarchar(50),	
	@EarMold	nvarchar(50),	
	@EarMoldLeft	nvarchar(50),	
	@EarMoldRight	nvarchar(50),	
	@OtherAccessories	nvarchar(50),	
	@Gaurantee	nvarchar(50),	
	@PTALeft	nvarchar(50),	
	@PTARight	nvarchar(50),	

	@Total MONEY, 
	@Valid_Days nvarchar(10) , 
	
	@Remarks NTEXT
	
    
AS 

IF EXISTS

	(SELECT [HearingQuotationID] FROM [tblHearingQuotation] WHERE [HearingQuotationID]=@HearingQuotationID)

	BEGIN
		UPDATE [tblHearingQuotation] 	
	SET  
	QuotationNo=@QuotationNo,
	[CustomerName]=@CustomerName, 
	Address1=@Address1,
	Address2=@Address2, 
	Address3=@Address3, 
	Age=@Age, 
	[Date]=@Date, 
	Occupation=@Occupation, 
	[Valid Days]=@Valid_Days,
	
	Audiogram=@Audiogram,	
	BrandModal=@BrandModal,
	BrandModalLeft	=@BrandModalLeft,	
	BrandModalRight = @BrandModalRight,	
	EarMold =@EarMold,	
	EarMoldLeft =@EarMoldLeft,	
	EarMoldRight =@EarMoldRight,	
	OtherAccessories =@OtherAccessories,		
	Gaurantee =@Gaurantee,		
	PTALeft =@PTALeft,	
	PTARight =@PTARight,
	
	Total=@Total, 	 
	Remarks=@Remarks
		
	WHERE 
			[HearingQuotationID]= @HearingQuotationID
	END

ELSE

INSERT INTO [tblHearingQuotation]
	([QuotationNo], 
	[CustomerName],
	[Address1],
	[Address2],
	[Address3],
	[Age],
	[Date],
	[Occupation],
	[Valid Days],
	[Audiogram],
	[BrandModal],
	[BrandModalLeft],
	[BrandModalRight],
	[EarMold],
	[EarMoldLeft],
	[EarMoldRight],
	[OtherAccessories],
	[Gaurantee],
	[PTALeft],
	[PTARight],	
	
	[Total],
	
	[Remarks],
	[IsActive]) 
VALUES  
	  
	(@QuotationNo,
	@CustomerName,
	@Address1,
	@Address2,
	@Address3,
	@Age, 
	@Date,
	@Occupation,
	@Valid_Days,	
	@Audiogram,
	@BrandModal,
	@BrandModalLeft,
	@BrandModalRight,
	@EarMold,
	@EarMoldLeft,
	@EarMoldRight,
	@OtherAccessories,
	@Gaurantee,
	@PTALeft,
	@PTARight,
	
	@Total ,
	@Remarks,
	1)
	

	' 
END
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_GetByID]    Script Date: 11/24/2012 11:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_GetByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[HearingQuotation_GetByID]
	@HearingQuotationID bigint

AS 

SELECT     HearingQuotationID, QuotationNo, CustomerName, Address1, Address2, Address3, Age, Date, Occupation, Audiogram, BrandModalLeft, BrandModalRight, EarMold, 
                      EarMoldLeft, EarMoldRight, OtherAccessories, PTALeft, PTARight, Total, [Valid Days],  Remarks, IsActive, Gaurantee, BrandModal
FROM         tblHearingQuotation

WHERE [HearingQuotationID]=@HearingQuotationID
	' 
END
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_GetAll]    Script Date: 11/24/2012 11:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_GetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[HearingQuotation_GetAll]


AS 

SELECT     HearingQuotationID, QuotationNo, CustomerName, Address1, Address2, Address3, Age, Date, Occupation, Audiogram, BrandModalLeft, BrandModalRight, EarMold, 
                      EarMoldLeft, EarMoldRight, OtherAccessories, PTALeft, PTARight, Total, [Valid Days],  Remarks, IsActive, Gaurantee
FROM         tblHearingQuotation
Where isActive=1' 
END
GO
/****** Object:  StoredProcedure [dbo].[HearingQuotation_Delete]    Script Date: 11/24/2012 11:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HearingQuotation_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create PROCEDURE [dbo].[HearingQuotation_Delete]
	(@HearingQuotationID	bigint)

AS 

update tblHearingQuotation

set IsActive=0
Where [HearingQuotationID] =@HearingQuotationID
     ' 
END
GO
