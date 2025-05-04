[Setup]
AppName=Quản Lý Vật Liệu Xây Dựng
AppVersion=1.0.2
DefaultDirName={autopf}\QLVLXD
DefaultGroupName=Quản Lý Vật Liệu Xây Dựng
UninstallDisplayIcon={app}\WinFormsApp1.exe
OutputBaseFilename=Setup_QLVLXD
Compression=lzma
SolidCompression=yes

[Files]
Source: "D:\WinFormsApp1\Installer\Source\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\Quản Lý Vật Liệu Xây Dựng"; Filename: "{app}\WinFormsApp1.exe"
Name: "{commondesktop}\Quản Lý Vật Liệu Xây Dựng"; Filename: "{app}\WinFormsApp1.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Tạo shortcut ngoài màn hình"; GroupDescription: "Tùy chọn shortcut"

[Run]
Filename: "{app}\WinFormsApp1.exe"; Description: "Chạy ứng dụng sau khi cài đặt"; Flags: nowait postinstall skipifsilent
