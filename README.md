# YARM CLI #

**YARM CLI** is a console application to help [ARM](https://docs.microsoft.com/en-us/azure/azure-resource-manager/) template authoring in [YAML](http://yaml.org/). Even though ARM templates officially only support JSON format, YAML as a superset of JSON is much better for writing ARM templates that have complex structure.


## Getting Started ##

With **YARM CLI**, you can easily convert your YAML documents to JSON and/or vice versa.

### Basic Command ###

The command is dead simple.

```command
yarm -i [INPUT_FILE_NAME] -o [OUTPUT_FILE_NAME]
```


### YAML to JSON ###

```commmand
yarm -i [YAML_FILE_NAME]
```

If no output name is specified, it stores the same location of the input file with `.json` extension. You can even convert YAML from the Internet.

```commmand
yarm -i https://raw.githubusercontent.com/TeamYARM/YARM-CLI/master/samples/azuredeploy.yaml
```

If no output name is specified, it stores the current location using the same file name with `.json` extension.


### JSON to YAML ###

```commmand
yarm -i [JSON_FILE_NAME]
```

If no output name is specified, it stores the same location of the input file with `.yaml` extension. You can even convert JSON from the Internet.

```commmand
yarm -i https://raw.githubusercontent.com/TeamYARM/YARM-CLI/master/samples/azuredeploy.json
```


## Contribution ##

Your contributions are always welcome! All your work should be done in your forked repository. Once you finish your work with corresponding tests, please send us a pull request onto our `dev` branch for review.


## License ##

**YARM CLI** is released under [MIT License](http://opensource.org/licenses/MIT)

> The MIT License (MIT)
>
> Copyright (c) 2018 Team YARM
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
> 
> The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
> 
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
