# FortiToken_410_Manager

## Table of Contents:
- Features
- Setup Instructions
- Credits

## Features:

### Main purpose:
- Enable and disable HOTP on a FortiToken 410 which already has FIDO implemented.
  
### Application type:
- WinForms C# application.

### User interface:
- Displays a key status when a key is inserted.
- Displays a key protocol to show whether FIDO and HOTP are enabled or only FIDO is enabled.
- Has buttons to enable and disable HOTP which are disabled depending on the key protocol.

### Build-in error checking:
- Checks if the inserted key is a correct FortiToken 410 and is accessible.
- Makes sure enabling/disabling of HOTP runs successfully.

## Setup Instructions:

### OS:
- Windows only, does not work cross platform.

### Required Software and tools:
- Visual Studio 2022 with WinForms and .NET 8.0 or newer installed
- A FortiToken 410

### Instructions:
- Run ```FortiToken_410_Manager.exe``` as **Administrator**.   
- The file is found in:   
```\FortiToken_410_Manager\FortiToken_410_Manager\bin\x86\Release\net8.0-windows```
- *Please ignore the other folders in the ```bin``` folder.

## Credits:
- **Reference:** VS2022-HyperFIDOPro-HOTP-Seed-Generator
- **Authors:** Mu Ye, Sakura
