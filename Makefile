CC      = mcs 
TARGET	= main.exe 
BIN_DIR = bin
WEB_DEST = /var/www/memorize

GUITARGET = app.exe

GUICONF = -pkg:gtk-sharp-2.0 -define:_M_GUI

OBJECTS = Items/*.cs \
		Attributes/*.cs \

GUIOBJECTS = $(OBJECTS) \
			 Desktop-UI/*.cs \
			 
WEBOBJECTS = $(OBJECTS) \

all: console gui web

makebin:
	mkdir -p $(BIN_DIR)

copyres:
	cp -R res $(BIN_DIR)/.

console: makebin
	$(CC) main.cs $(OBJECTS) -out:$(BIN_DIR)/$(TARGET)

gui: makebin copyres
	$(CC) $(GUICONF) $(GUIOBJECTS) -out:$(BIN_DIR)/$(GUITARGET)

web:
	cp -R $(WEBOBJECTS) $(WEBDEST)/.

clean: 
	rm -f $(TARGET) $(GUITARGET)
