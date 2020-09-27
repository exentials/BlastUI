const { CleanWebpackPlugin } = require("clean-webpack-plugin");
const path = require("path");

module.exports = function (env, { mode }) {
    const production = mode === 'production';
    return {
        mode: production ? 'production' : 'development',
        devtool: production ? 'source-maps' : 'inline-source-map',
        entry: {
            app: ['./src/blastui.ts']
        },
        output: {
            filename: 'blastui.js',
            path: path.resolve(__dirname, 'wwwroot/js')
        },
        resolve: {
            extensions: ['.ts', '.js'],
            modules: ['src', 'node_modules']
        },
        devServer: {
            port: 9000,
            historyApiFallback: true,
            writeToDisk: true,
            open: !process.env.CI,
            lazy: false
        },
        plugins: [
            new CleanWebpackPlugin()
        ],
        module: {
            rules: [
                {
                    test: /\.ts$/i,
                    use: [
                        {
                            loader: 'ts-loader'
                        }
                    ],
                    exclude: /node_modules/
                }
            ]
        }
    }
}