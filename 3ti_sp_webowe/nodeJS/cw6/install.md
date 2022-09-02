## Process instalacji
Aplikacja z formularzem typescript
pole tekstowe oraz pole na ilość
i przycisk do generowania listy numerowanej

### Instalacja
```console
npm init -y
npm i typescript --save-dev
npx tsc -init

```

### tsconfig
```json
{
  "compilerOptions": {
    "module": "ES6",
    "target": "es2022",
    "outDir": "./dist",
    "rootDir": "./src"
  }
}

```

### package.json
```json
{
  "name": "cw6",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "module": "module",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1"
  },
  "author": "",
  "license": "ISC",
  "devDependencies": {
    "typescript": "^4.8.2"
  }
}

```