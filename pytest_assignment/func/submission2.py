filetype = ["doc", "pdf","jpg"]

def submitfile(file):
    if file in filetype:
        print("file sumbitted")
        nexstep = True
    else:
        print("invalid file type, please submit another one")
        nexstep = False
    return nexstep        