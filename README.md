# Getting started

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (EdiNationAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=EdiNation%20API-CSharp&workspaceName=EdiNationAPI&projectName=EdiNationAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the EdiNationAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=EdiNation%20API-CSharp&workspaceName=EdiNationAPI&projectName=EdiNationAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=EdiNation%20API-CSharp&workspaceName=EdiNationAPI&projectName=EdiNationAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=EdiNation%20API-CSharp&workspaceName=EdiNationAPI&projectName=EdiNationAPI.Standard)

### 3. Add reference of the library project

In order to use the EdiNationAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=EdiNation%20API-CSharp&workspaceName=EdiNationAPI&projectName=EdiNationAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` EdiNationAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```EdiNationAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=EdiNation%20API-CSharp&workspaceName=EdiNationAPI&projectName=EdiNationAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=EdiNation%20API-CSharp&workspaceName=EdiNationAPI&projectName=EdiNationAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| ocpApimSubscriptionKey | API key to authenticate requests |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string ocpApimSubscriptionKey = "ocpApimSubscriptionKey"; // API key to authenticate requests

EdiNationAPIClient client = new EdiNationAPIClient(ocpApimSubscriptionKey);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [EdifactController](#edifact_controller)
* [EdiModelController](#edi_model_controller)
* [X12Controller](#x12_controller)

## <a name="edifact_controller"></a>![Class: ](https://apidocs.io/img/class.png "EdiNationAPI.Standard.Controllers.EdifactController") EdifactController

### Get singleton instance

The singleton instance of the ``` EdifactController ``` class can be accessed from the API Client.

```csharp
EdifactController edifact = client.Edifact;
```

### <a name="read"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdifactController.Read") Read

> Reads an EDIFACT file and returns its contents translated to an array of EdifactInterchange objects.


```csharp
Task<List<Models.EdifactInterchange>> Read(
        FileStreamInfo fileName,
        bool? ignoreNullValues = false,
        bool? continueOnError = false,
        string charSet = "utf-8",
        string model = null,
        bool? eancomS3 = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fileName |  ``` Required ```  | Upload File |
| ignoreNullValues |  ``` Optional ```  ``` DefaultValue ```  | Whether to ignore all null values in the response. The default is false. |
| continueOnError |  ``` Optional ```  ``` DefaultValue ```  | Whether to continue reading if a corrupt interchange is encountered. The default is false. |
| charSet |  ``` Optional ```  ``` DefaultValue ```  | The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16. |
| model |  ``` Optional ```  | The model to use. By default, the API will infer the model based on the transaction and version identifiers. |
| eancomS3 |  ``` Optional ```  ``` DefaultValue ```  | The default syntax for EANCOM transactions. By default all EANCOM transactions will be translated and validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used. |


#### Example Usage

```csharp
FileStreamInfo fileName = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));
bool? ignoreNullValues = false;
bool? continueOnError = false;
string charSet = "utf-8";
string model = "model";
bool? eancomS3 = false;

List<Models.EdifactInterchange> result = await edifact.Read(fileName, ignoreNullValues, continueOnError, charSet, model, eancomS3);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="write"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdifactController.Write") Write

> Translates an EdifactInterchange object to a raw EDIFACT interchange and returns it as a stream.


```csharp
Task<Stream> Write(
        bool? preserveWhitespace = false,
        string charSet = "utf-8",
        string postfix = null,
        bool? sameRepetionAndDataElement = false,
        bool? eancomS3 = false,
        string contentType = "application/json",
        Models.EdifactInterchange body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| preserveWhitespace |  ``` Optional ```  ``` DefaultValue ```  | Whether to preserve blank data elements so the output contains multiple delimiters instead of omitting any excess delimiters. The default is false. |
| charSet |  ``` Optional ```  ``` DefaultValue ```  | The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16. |
| postfix |  ``` Optional ```  | The postfix to be applied at the end of each segment, just after the segment separator. This is usually a carriage return (CR), line feed (LF) or both. By default, there is no postfix. |
| sameRepetionAndDataElement |  ``` Optional ```  ``` DefaultValue ```  | Sometimes the same delimiter is used to denote data element separator and repetition separator as in IATA transactions. By default, this is false. |
| eancomS3 |  ``` Optional ```  ``` DefaultValue ```  | The default syntax for EANCOM transactions. By default all EANCOM transactions will be translated and validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used. |
| contentType |  ``` Optional ```  ``` DefaultValue ```  | application/json |
| body |  ``` Optional ```  | The EdifactInterchange object to translate to raw EDIFACT. |


#### Example Usage

```csharp
bool? preserveWhitespace = false;
string charSet = "utf-8";
string postfix = "postfix";
bool? sameRepetionAndDataElement = false;
bool? eancomS3 = false;
string contentType = "application/json";
var body = new Models.EdifactInterchange();

Stream result = await edifact.Write(preserveWhitespace, charSet, postfix, sameRepetionAndDataElement, eancomS3, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="validate"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdifactController.Validate") Validate

> Validates an EdifactInterchange object according to the EDIFACT standard rules for each version and transaction.


```csharp
Task<Models.OperationResult> Validate(
        string syntaxSet = null,
        bool? skipTrailer = false,
        bool? structureOnly = false,
        string decimalPoint = ".",
        bool? eancomS3 = false,
        string contentType = "application/json",
        Models.EdifactInterchange body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| syntaxSet |  ``` Optional ```  | In case you need to validate against a syntax set, different than UNOA and UNOB, populate this filed with all of the allowed symbols, url-escaped. All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The supported syntax sets are UNOA and UNOB. The validator infers the correct syntax set from EdifactInterchange.UNB.SYNTAXIDENTIFIER_1.SyntaxIdentifier_1. The symbols added to this field will override the corresponding sets in both UNOA and UNOB. |
| skipTrailer |  ``` Optional ```  ``` DefaultValue ```  | You are allowed to validate an EdifactInterchange with missing interchange, functional group or transaction trailers (UNZ, UNE, UNT). This is because these will be automatically applied during the Write oprtaion so you don't have to worry about counting the items. By default it is expected that all trailers are present when you validate the EdifactInterchange and by default, this is set to false. To skip all trailer validation, set this to true. |
| structureOnly |  ``` Optional ```  ``` DefaultValue ```  | This is equivalent to HIPAA Snip level 1, where only the structure and control segments are validated. By default, this is set to false, however if you want to not validate things such as data types, number of repeteitions or dates, set this to true. |
| decimalPoint |  ``` Optional ```  ``` DefaultValue ```  | This could be either point . (default) or comma ,. |
| eancomS3 |  ``` Optional ```  ``` DefaultValue ```  | The default syntax for EANCOM transactions. By default all EANCOM transactions will be validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used. |
| contentType |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | The EdifactInterchange object to validate. |


#### Example Usage

```csharp
string syntaxSet = "syntaxSet";
bool? skipTrailer = false;
bool? structureOnly = false;
string decimalPoint = ".";
bool? eancomS3 = false;
string contentType = "application/json";
var body = new Models.EdifactInterchange();

Models.OperationResult result = await edifact.Validate(syntaxSet, skipTrailer, structureOnly, decimalPoint, eancomS3, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="ack"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdifactController.Ack") Ack

> Generates functional and/or technical CONTRL acknowledment(s) for the requested EdifactInterchange.


```csharp
Task<List<Models.EdifactInterchange>> Ack(
        string syntaxSet = null,
        bool? detectDuplicates = false,
        int? tranRefNumber = 1,
        int? interchangeRefNumber = 1,
        bool? ackForValidTrans = false,
        bool? batchAcks = true,
        string technicalAck = null,
        bool? eancomS3 = false,
        string contentType = "application/json",
        Models.EdifactInterchange body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| syntaxSet |  ``` Optional ```  | In case you need to validate against a syntax set, different than UNOA and UNOB, populate this filed with all of the allowed symbols, url-escaped. All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The supported syntax sets are UNOA and UNOB. The validator infers the correct syntax set from EdifactInterchange.UNB.SYNTAXIDENTIFIER_1.SyntaxIdentifier_1. The symbols added to this field will override the corresponding sets in both UNOA and UNOB. |
| detectDuplicates |  ``` Optional ```  ``` DefaultValue ```  | If you need to detect duplicates as in functional groups or transactions with the same reference number, set this flag to true. The default is false. |
| tranRefNumber |  ``` Optional ```  ``` DefaultValue ```  | The default is 1. Set this to whatever the CONTRL UNH.MessageReferenceNumber_01 needs to be. |
| interchangeRefNumber |  ``` Optional ```  ``` DefaultValue ```  | The default is 1. Set this to whatever the CONTRL EdifactInterchange.UNB.InterchangeControlReference_5 needs to be. |
| ackForValidTrans |  ``` Optional ```  ``` DefaultValue ```  | The default is false. Set this to true if you need UCM loops included for all valid transaction as well. By default UCM loops are generated only for invalid transactions. |
| batchAcks |  ``` Optional ```  ``` DefaultValue ```  | The default is true. Set this to false if you need to generate separate EdifactInterchange for each acknowledgment. By default all acknowledgments are batched in the same EdifactInterchange. |
| technicalAck |  ``` Optional ```  | The default technical acknowledgment CONTRL is generated according to EdifactInterchange.UNB.AcknowledgementRequest_9. You can either enforce it to always generate technical CONTRLs or supress it to never generate any technical CONTRLs. This will override the flag in EdifactInterchange.UNB.AcknowledgementRequest_9.
            The available values are: default, enforce, suppress. |
| eancomS3 |  ``` Optional ```  ``` DefaultValue ```  | The default syntax for EANCOM transactions. By default all EANCOM transactions will be validated according to the rules of Syntax 4. Set this flag to true if you need Syntax 3 to be used. |
| contentType |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | The EdifactInterchange object to acknowledge. |


#### Example Usage

```csharp
string syntaxSet = "syntaxSet";
bool? detectDuplicates = false;
int? tranRefNumber = 1;
int? interchangeRefNumber = 1;
bool? ackForValidTrans = false;
bool? batchAcks = true;
string technicalAck = "technicalAck";
bool? eancomS3 = false;
string contentType = "application/json";
var body = new Models.EdifactInterchange();

List<Models.EdifactInterchange> result = await edifact.Ack(syntaxSet, detectDuplicates, tranRefNumber, interchangeRefNumber, ackForValidTrans, batchAcks, technicalAck, eancomS3, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="edi_model_controller"></a>![Class: ](https://apidocs.io/img/class.png "EdiNationAPI.Standard.Controllers.EdiModelController") EdiModelController

### Get singleton instance

The singleton instance of the ``` EdiModelController ``` class can be accessed from the API Client.

```csharp
EdiModelController ediModel = client.EdiModel;
```

### <a name="upload"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdiModelController.Upload") Upload

> Uploads a model file to a subscription. It must be a valid DOT NET assembly.


```csharp
Task Upload(FileStreamInfo fileName)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fileName |  ``` Required ```  | Upload File |


#### Example Usage

```csharp
FileStreamInfo fileName = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));

await ediModel.Upload(fileName);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="get_models"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdiModelController.GetModels") GetModels

> Retrieves all models for a subscription.


```csharp
Task<List<Models.EdiModel>> GetModels(bool? system = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| system |  ``` Optional ```  ``` DefaultValue ```  | Whether to retrieve EdiNation's or custom uploaded models. |


#### Example Usage

```csharp
bool? system = true;

List<Models.EdiModel> result = await ediModel.GetModels(system);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="get_model"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdiModelController.GetModel") GetModel

> Retrieve a particular model file as a stream.


```csharp
Task<Stream> GetModel(string id, bool? system = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The model name. |
| system |  ``` Optional ```  ``` DefaultValue ```  | Whether to search in EdiNation's or custom uploaded models. |


#### Example Usage

```csharp
string id = "id";
bool? system = true;

Stream result = await ediModel.GetModel(id, system);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="delete"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.EdiModelController.Delete") Delete

> Deletes a particular model from the custom models.


```csharp
Task Delete(string id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The model name. |


#### Example Usage

```csharp
string id = "id";

await ediModel.Delete(id);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="x12_controller"></a>![Class: ](https://apidocs.io/img/class.png "EdiNationAPI.Standard.Controllers.X12Controller") X12Controller

### Get singleton instance

The singleton instance of the ``` X12Controller ``` class can be accessed from the API Client.

```csharp
X12Controller x12 = client.X12;
```

### <a name="read"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.X12Controller.Read") Read

> Reads an X12 file and returns its contents translated to an array of X12Interchange objects.


```csharp
Task<List<Models.X12Interchange>> Read(
        FileStreamInfo fileName,
        bool? ignoreNullValues = false,
        bool? continueOnError = false,
        string charSet = "utf-8",
        string model = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fileName |  ``` Required ```  | Upload File |
| ignoreNullValues |  ``` Optional ```  ``` DefaultValue ```  | Whether to ignore all null values in the response. The default is false. |
| continueOnError |  ``` Optional ```  ``` DefaultValue ```  | Whether to continue reading if a corrupt interchange is encountered. The default is false. |
| charSet |  ``` Optional ```  ``` DefaultValue ```  | The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16. |
| model |  ``` Optional ```  | The model to use. By default, the API will infer the model based on the transaction and version identifiers. |


#### Example Usage

```csharp
FileStreamInfo fileName = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));
bool? ignoreNullValues = false;
bool? continueOnError = false;
string charSet = "utf-8";
string model = "model";

List<Models.X12Interchange> result = await x12.Read(fileName, ignoreNullValues, continueOnError, charSet, model);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="write"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.X12Controller.Write") Write

> Translates an X12Interchange object to a raw X12 interchange and returns it as a stream.


```csharp
Task<Stream> Write(
        bool? preserveWhitespace = false,
        string charSet = "utf-8",
        string postfix = null,
        string contentType = "application/json",
        Models.X12Interchange body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| preserveWhitespace |  ``` Optional ```  ``` DefaultValue ```  | Whether to preserve blank data elements so the output contains multiple delimiters instead of omitting any excess delimiters. The default is false. |
| charSet |  ``` Optional ```  ``` DefaultValue ```  | The encoding of the file contents. The default is utf-8. The available values are: unicodeFFFE, utf-32, utf-32BE, us-ascii, iso-8859-1, utf-7, utf-8, utf-16. |
| postfix |  ``` Optional ```  | The postfix to be applied at the end of each segment, just after the segment separator. This is usually a carriage return (CR), line feed (LF) or both. By default, there is no postfix. |
| contentType |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | The X12Interchange object to translate to raw X12. |


#### Example Usage

```csharp
bool? preserveWhitespace = false;
string charSet = "utf-8";
string postfix = "postfix";
string contentType = "application/json";
var body = new Models.X12Interchange();

Stream result = await x12.Write(preserveWhitespace, charSet, postfix, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="validate"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.X12Controller.Validate") Validate

> Validates an X12Interchange object according to the X12 standard rules for each version and transaction.


```csharp
Task<Models.OperationResult> Validate(
        bool? basicSyntax = false,
        string syntaxSet = null,
        bool? skipTrailer = false,
        bool? structureOnly = false,
        string contentType = "application/json",
        Models.X12Interchange body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| basicSyntax |  ``` Optional ```  ``` DefaultValue ```  | All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The default syntax set is the Extended, hence the default for this parameter is false. By setting this to true, validation will use the Basic syntax set. |
| syntaxSet |  ``` Optional ```  | In case you need to validate against a syntax set, different than Basic and Extended, populate this filed with all of the allowed symbols, url-escaped. |
| skipTrailer |  ``` Optional ```  ``` DefaultValue ```  | You are allowed to validate an X12Interchange with missing interchange, functional group or transaction trailers (IEA, GE, SE). This is because these will be automatically applied during the Write oprtaion so you don't have to worry about counting the items. By default it is expected that all trailers are present when you validate the X12Interchange and by default, this is set to false. To skip all trailer validation, set this to true. |
| structureOnly |  ``` Optional ```  ``` DefaultValue ```  | This is equivalent to HIPAA Snip level 1, where only the structure and control segments are validated. By default, this is set to false, however if you want to not validate things such as data types, number of repeteitions or dates, set this to true. |
| contentType |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | The X12Interchange object to validate. |


#### Example Usage

```csharp
bool? basicSyntax = false;
string syntaxSet = "syntaxSet";
bool? skipTrailer = false;
bool? structureOnly = false;
string contentType = "application/json";
var body = new Models.X12Interchange();

Models.OperationResult result = await x12.Validate(basicSyntax, syntaxSet, skipTrailer, structureOnly, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


### <a name="ack"></a>![Method: ](https://apidocs.io/img/method.png "EdiNationAPI.Standard.Controllers.X12Controller.Ack") Ack

> Generates functional/implementation and/or technical acknowledment(s) for the requested X12Interchange.


```csharp
Task<List<Models.X12Interchange>> Ack(
        bool? basicSyntax = false,
        string syntaxSet = null,
        bool? detectDuplicates = false,
        int? tranRefNumber = 1,
        int? interchangeRefNumber = 1,
        bool? ackForValidTrans = false,
        bool? batchAcks = true,
        string technicalAck = null,
        string ack = "997",
        bool? ak901isP = false,
        string contentType = "application/json",
        Models.X12Interchange body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| basicSyntax |  ``` Optional ```  ``` DefaultValue ```  | All data elements with alpha (A) or alphanumeric (AN) data types are validated against a syntax set of allowed characters. The default syntax set is the Extended, hence the default for this parameter is false. By setting this to true, validation will use the Basic syntax set. |
| syntaxSet |  ``` Optional ```  | In case you need to validate against a syntax set, different than Basic and Extended, populate this filed with all of the allowed symbols, url-escaped. |
| detectDuplicates |  ``` Optional ```  ``` DefaultValue ```  | If you need to detect duplicates as in functional groups or transactions with the same reference number, set this flag to true. The default is false. |
| tranRefNumber |  ``` Optional ```  ``` DefaultValue ```  | The default is 1. Set this to whatever the 997 or 999 X12Interchange.ST.TransactionSetControlNumber_02 needs to be. In case there are multiple acknowledgments (for multiple functional groups), this will be starting reference number and every subsequent acknowledgment will have the previous reference number incremented with 1. |
| interchangeRefNumber |  ``` Optional ```  ``` DefaultValue ```  | The default is 1. Set this to whatever the 997 or 999 X12Interchange.ISA.InterchangeControlNumber_13 needs to be. |
| ackForValidTrans |  ``` Optional ```  ``` DefaultValue ```  | The default is false. Set this to true if you need AK2 loops included for all valid transaction as well. By default AK2 loops are generated only for invalid transactions. |
| batchAcks |  ``` Optional ```  ``` DefaultValue ```  | The default is true. Set this to false if you need to generate separate X12Interchange for each acknowledgment. By default all acknowledgments are batched in the same X12Interchange. |
| technicalAck |  ``` Optional ```  | The default technical acknowledgment TA1 is generated according to X12Interchange.ISA.AcknowledgementRequested_14. You can either enforce it to always generate TA1s or supress it to never generate any TA1s. This will override the flag in X12Interchange.ISA.AcknowledgementRequested_14.
            The available values are: default, enforce, suppress. |
| ack |  ``` Optional ```  ``` DefaultValue ```  | The default value is 997. The type of acknowledgment being generated. Set this to 999 if you need to generate an implementation instead of functional acknowledgment. The available values are: 997, 999. |
| ak901isP |  ``` Optional ```  ``` DefaultValue ```  | The value of the AK9's first element. By default it is "E". Set this to true if you want this value to be "P" instead. |
| contentType |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | The X12Interchange object to acknowledge. |


#### Example Usage

```csharp
bool? basicSyntax = false;
string syntaxSet = "syntaxSet";
bool? detectDuplicates = false;
int? tranRefNumber = 1;
int? interchangeRefNumber = 1;
bool? ackForValidTrans = false;
bool? batchAcks = true;
string technicalAck = "technicalAck";
string ack = "997";
bool? ak901isP = false;
string contentType = "application/json";
var body = new Models.X12Interchange();

List<Models.X12Interchange> result = await x12.Ack(basicSyntax, syntaxSet, detectDuplicates, tranRefNumber, interchangeRefNumber, ackForValidTrans, batchAcks, technicalAck, ack, ak901isP, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 500 | Server Error |


[Back to List of Controllers](#list_of_controllers)



