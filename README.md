# WebMassa2.0

Sem fazer nada um gerador de massa de dados para brincar com os alunos

Swagger UI
Select a definition

WebGeradorMassaDados v1
WebGeradorMassaDados
 1.0 
OAS3
https://localhost:7120/swagger/v1/swagger.json
GerarNomeLista


GET
​/GerarNomeLista
GerarNomes


GET
​/GerarNomes
ListaPessoas


GET
​/ListaPessoas
Parameters
Cancel
Name	Description
IdadeInicial
integer($int32)
(query)	
0
IdadeFinal
integer($int32)
(query)	
100
QuantasPessoas
integer($int32)
(query)	
1
Execute
Clear
Responses
Curl

curl -X 'GET' \
  'https://localhost:7120/ListaPessoas?IdadeInicial=0&IdadeFinal=100&QuantasPessoas=1' \
  -H 'accept: text/plain'
Request URL
https://localhost:7120/ListaPessoas?IdadeInicial=0&IdadeFinal=100&QuantasPessoas=1
Server response
Code	Details
200	
Response body
Download
[
  {
    "nome": "Anaísa",
    "sobrenome": "Borsoi Barros Camões Lutz Melo",
    "datanascimento": "1971-04-10T22:02:39.4963292-03:00",
    "email": "Anaísa.Borsoi.Barros.Camões.Lutz.Melo@yahoo.com",
    "cpf": "56414685500",
    "fone": "(43) 99772 - 6975",
    "sexo": "F",
    "estadocivil": "Separado",
    "hobbie": "29. Jogar vôlei",
    "idade": 52
  }
]
Response headers
 content-type: application/json; charset=utf-8 
 date: Tue,16 May 2023 01:02:38 GMT 
 server: Kestrel 
Responses
Code	Description	Links
200	
Success

Media type

text/plain
Controls Accept header.
Example Value
Schema
[
  {
    "nome": "string",
    "sobrenome": "string",
    "datanascimento": "2023-05-16T01:02:39.576Z",
    "email": "string",
    "cpf": "string",
    "fone": "string",
    "sexo": "string",
    "estadocivil": "string",
    "hobbie": "string",
    "idade": 0
  }
]
No links
Pessoa


GET
​/Pessoa
Parameters
Cancel
Name	Description
IdadeInicial
integer($int32)
(query)	
IdadeInicial
IdadeFinal
integer($int32)
(query)	
IdadeFinal
Execute
Responses
Code	Description	Links
200	
Success

Media type

text/plain
Controls Accept header.
Example Value
Schema
{
  "nome": "string",
  "sobrenome": "string",
  "datanascimento": "2023-05-16T01:02:39.578Z",
  "email": "string",
  "cpf": "string",
  "fone": "string",
  "sexo": "string",
  "estadocivil": "string",
  "hobbie": "string",
  "idade": 0
}
No links

Schemas
Pessoa
