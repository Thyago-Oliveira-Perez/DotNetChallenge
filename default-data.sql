INSERT INTO commonUsers (
    Id,
    Name,
    Email,
    CPF,
    Password,
    Balance,
    CreatedAt
  )
VALUES (
    NEWID(),
    'Alice',
    'alice@example.com',
    '123.456.789-00',
    'senha123',
    1000,
    GETDATE()
  );
INSERT INTO tradesman (
    Id,
    Name,
    Email,
    CPF,
    Password,
    Balance,
    CNPJ,
    CreatedAt
  )
VALUES (
    NEWID(),
    'Tradesman 1',
    'tradesman1@example.com',
    '222.333.444-55',
    'senhaTradesman1',
    2000,
    '11.222.333/0001-44',
    GETDATE()
  );