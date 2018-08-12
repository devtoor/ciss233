CREATE TABLE [dbo].[Customer] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [first]     VARCHAR (50) NOT NULL,
    [last]      VARCHAR (50) NOT NULL,
    [street]    VARCHAR (50) NOT NULL,
    [city]      VARCHAR (50) NOT NULL,
    [state]     VARCHAR (50) NOT NULL,
    [zip]       VARCHAR (50) NOT NULL,
    [phone]     VARCHAR (50) NOT NULL,
    [phonetype] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);