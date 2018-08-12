CREATE TABLE [dbo].[Orders] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [custId]     INT          NOT NULL,
    [orderdate]  VARCHAR (50) NOT NULL,
    [ordertime]  VARCHAR (50) NOT NULL,
    [prod1Qty]   INT          NOT NULL,
    [prod2Qty]   INT          NOT NULL,
    [prod3Qty]   INT          NOT NULL,
    [prod4Qty]   INT          NOT NULL,
    [prod5Qty]   INT          NOT NULL,
    [prod6Qty]   INT          NOT NULL,
    [subtotal]   DECIMAL(18, 2)        NOT NULL,
    [taxAmt]     DECIMAL(18, 2)        NOT NULL,
    [grandtotal] DECIMAL(18, 2)        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Orders_Customer] FOREIGN KEY ([custId]) REFERENCES [Customer]([Id])
);
