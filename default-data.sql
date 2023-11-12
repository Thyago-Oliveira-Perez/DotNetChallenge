CREATE EXTENSION IF NOT EXISTS "uuid-ossp";
INSERT INTO public."commonUsers" (
    "Id",
    "Name",
    "Email",
    "CPF",
    "Password",
    "Balance",
    "CreatedAt"
  )
VALUES (
    uuid_generate_v4(),
    'Alice',
    'alice@example.com',
    '123.456.789-00',
    'senha123',
    1000,
    CURRENT_TIMESTAMP
  );
INSERT INTO public.tradesman (
    "Id",
    "Name",
    "Email",
    "CPF",
    "Password",
    "Balance",
    "CNPJ",
    "CreatedAt"
  )
VALUES (
    uuid_generate_v4(),
    'Tradesman 1',
    'tradesman1@example.com',
    '222.333.444-55',
    'senhaTradesman1',
    2000,
    '11.222.333/0001-44',
    CURRENT_TIMESTAMP
  );