import os
import shutil

current_dir = os.getcwd()

for f in os.listdir(current_dir):
    filename, file_ext = os.path.splitext(f)

    try:
        if not file_ext:
            pass
        elif file_ext in ('.py'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Python', f'{filename}{file_ext}')
            )
        elif file_ext in ('.jpg', '.png', '.jpeg'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Pictures', f'{filename}{file_ext}')
            )
        elif file_ext in ('.odp'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Powerpoint', f'{filename}{file_ext}')
            )
        elif file_ext in ('.pdf'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Pdf', f'{filename}{file_ext}')
            )
        elif file_ext in ('.ods'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Excel', f'{filename}{file_ext}')
            )
        elif file_ext in ('.odt'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Word', f'{filename}{file_ext}')
            )
        elif file_ext in ('.mp4'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Videos', f'{filename}{file_ext}')
            )
        elif file_ext in ('.deb'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Deb', f'{filename}{file_ext}')
            )
        elif file_ext in ('.mp3'):
            shutil.move(
                os.path.join(current_dir, f'{filename}{file_ext}'),
                os.path.join(current_dir, 'Mp3', f'{filename}{file_ext}')
            )

    except (FileNotFoundError,PermissionError):
        pass
