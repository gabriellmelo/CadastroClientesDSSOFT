/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT TOP (1000) [id]
      ,[nome]
      ,[sobrenome]
      ,[idade]
      ,[endereco]
      ,[bairro]
      ,[cidade]
      ,[telefone]
  FROM [DADOS_PESSOAIS].[dbo].[Pessoas]