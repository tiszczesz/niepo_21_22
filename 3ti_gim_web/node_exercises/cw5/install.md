## Instalacja projektu
```console
npm init -y
npm i typescript --save-dev
npx tsc -init
```
## plik tsconfig
```js
{
  "compilerOptions": {
    "module": "ES6",
    "target": "es2022",
    "outDir": "./dist",
    "rootDir": "./src"
  }
}
```

## Instalacja Webpack
```console
npm i --save-dev webpack
npm i --save-dev webpack-cli
npm i --save-dev ts-loader
```