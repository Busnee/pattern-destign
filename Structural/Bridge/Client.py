import BridgePattern as pattern

wacom = pattern.Wacom(None,4)
wacom.setTabletKey(0,"\'\\x1a\'")   # ctrl z
wacom.setTabletKey(1,"<107>")       # ctrl +
wacom.setTabletKey(2,"<109>")       # ctrl -
wacom.setTabletKey(3,"\'i\'")

veikk = pattern.Veikk(None, 6)
veikk.setTabletKey(0,"\'\\x1a\'")   # ctrl z
veikk.setTabletKey(1,"\'\\x19\'")   # ctrl y
veikk.setTabletKey(2,"<107>")       # ctrl +
veikk.setTabletKey(3,"<109>")       # ctrl -
veikk.setTabletKey(4,"\'i\'")
veikk.setTabletKey(5,"\'p\'")

krita = pattern.Krita()
clipStudio = pattern.ClipStudio()

exit = False
while(not exit):
    txt = '''
    Select Graphics Tablet or Exit
    1. Wacom
    2. Veikk
    3. Exit
    '''
    print(txt + ">> ")
    tabletSelected = input()
    tablet:pattern.GraphicsTablet = None
    if(tabletSelected == "1"):
        tablet = wacom
    elif(tabletSelected == "2"):
        tablet = veikk
    elif(tabletSelected == "3"):
        exit = True
        break
    exitApp = False
    while(not exitApp):
        txt = '''
        Select Application or Exit
        1. Krita
        2. Clip Studio
        3. Exit
        '''
        print(txt + ">> ")
        appSelected = input()
        if(appSelected == '1'):
            tablet.setApp(krita)
            print("connect Krita application")
            krita.showShortcuts()
            tablet.startApp()
        elif(appSelected == '2'):
            tablet.setApp(clipStudio)
            print("connect Clip Studio application")
            clipStudio.showShortcuts()
            tablet.startApp()
        elif(appSelected == '3'):
            exitApp = True