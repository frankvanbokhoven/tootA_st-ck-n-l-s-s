;Include Modern UI

  !include "MUI2.nsh"
  !include "FileAssociation.nsh"

Name "Champion Stock Chart Viewer 1.01"
OutFile "ChampionStockChartViewer1.01Setup.exe"
InstallDir "$PROGRAMFILES\Zeta Centauri\Champion Stock Chart Viewer"
InstallDirRegKey HKLM "Software\Champion Stock Chart Viewer" "Install_Dir"
RequestExecutionLevel admin
!define MUI_ICON "CSCVLargeIcon.ico"
!define MUI_UNICON "CSCVLargeIcon.ico"

;Version Information

  VIProductVersion "1.0.1.0"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "Champion Stock Chart Viewer"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "Zeta Centauri"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "Copyright 2007-2013 Zeta Centauri"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "Stock Chart Viewer Installer"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "1.0.1.0"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductVersion" "1.0.1.0"

;Interface Settings

  !define MUI_ABORTWARNING

;Pages

  !insertmacro MUI_PAGE_LICENSE "License.txt"
;  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
      !define MUI_FINISHPAGE_NOAUTOCLOSE
      !define MUI_FINISHPAGE_RUN
      !define MUI_FINISHPAGE_RUN_CHECKED
      !define MUI_FINISHPAGE_RUN_TEXT "Launch Champion Stock Chart Viewer"
      !define MUI_FINISHPAGE_RUN_FUNCTION "LaunchProgram"
      !define MUI_FINISHPAGE_SHOWREADME ""
      !define MUI_FINISHPAGE_SHOWREADME_NOTCHECKED
      !define MUI_FINISHPAGE_SHOWREADME_TEXT "Create Desktop Shortcut"
      !define MUI_FINISHPAGE_SHOWREADME_FUNCTION finishpageaction
  !insertmacro MUI_PAGE_FINISH
  
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES

;Languages
 
  !insertmacro MUI_LANGUAGE "English"


; The stuff to install
Section "ChampionCharts"

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File "ChampionCharts.exe"
  File "License.txt"
  File "CSCVLargeIcon.ico"
  File "StockData.dll"

  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\ChampionCharts "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts" "DisplayName" "Champion Stock Chart Viewer"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts" "DisplayVersion" "1.01"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts" "Publisher" "Zeta Centauri"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts" "DisplayIcon" "$INSTDIR\CSCVLargeIcon.ico"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts" "NoRepair" 1
  WriteUninstaller "uninstall.exe"

SectionEnd

; Optional section (can be disabled by the user)
Section "Start Menu Shortcuts"

  CreateDirectory "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer"
  CreateShortCut "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer\Champion Stock Chart Viewer.lnk" "$INSTDIR\ChampionCharts.exe" "" "" 0
  ;CreateShortCut "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  WriteINIStr "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer\Champion Stock Chart Viewer Website.url" "InternetShortcut" "URL" "http://zetacentauri.com/software_championcharts.htm"
  
SectionEnd

; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\ChampionCharts"
  DeleteRegKey HKLM SOFTWARE\ChampionCharts

  ; Remove files and uninstaller
  Delete $INSTDIR\ChampionCharts.exe
  Delete $INSTDIR\License.txt
  Delete $INSTDIR\CSCVLargeIcon.ico
  Delete $INSTDIR\StockData.dll
  Delete $INSTDIR\uninstall.exe

  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer\*.*"
  Delete "$DESKTOP\Champion Stock Chart Viewer.lnk"
  Delete "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer\Champion Stock Chart Viewer Website.url"
  ;DeleteINISec "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer\Champion Stock Chart Viewer Website.url" "InternetShortcut"

  ; Remove directories used
  RMDir "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer"
  RMDir "$SMPROGRAMS\Zeta Centauri"
  RMDir "$INSTDIR"


SectionEnd

Function LaunchProgram
  ExecShell "" "$SMPROGRAMS\Zeta Centauri\Champion Stock Chart Viewer\Champion Stock Chart Viewer.lnk"
FunctionEnd

Function finishpageaction
  ;CreateShortCut "$DESKTOP\Champion Stock Chart Viewer.lnk" "$INSTDIR\ChampionCharts.exe" "" "" 0
  CreateShortcut "$DESKTOP\Champion Stock Chart Viewer.lnk" "$INSTDIR\ChampionCharts.exe"
FunctionEnd
