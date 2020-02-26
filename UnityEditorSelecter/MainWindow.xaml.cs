using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace UnityEditorSelecter
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filePath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void outPutButtonClick(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog("出力するフォルダ選択");
            dlg.IsFolderPicker = true;
            var ret = dlg.ShowDialog();
            if (ret == CommonFileDialogResult.Ok)
            {
                filePath = dlg.FileName;
                string showData = "";
                showData += createPrefabsFolder(filePath);
                showData += createScriptsFolder(filePath);
                showData += createAnimationsFolder(filePath);
                showData += createMaterialsFolder(filePath);
                showData += createPhysicsMaterialsFolder(filePath);
                showData += createFontsFolder(filePath);
                showData += createTexturesFolder(filePath);
                showData += createAudioFolder(filePath);
                showData += createResourcesFolder(filePath);
                showData += createEditorFolder(filePath);
                showData += createPluginsFolder(filePath);
                MessageBox.Show(showData);
            }
        }

        private string createPrefabsFolder(string filePath)
        {
            string prefabsFilePath = (filePath + "/Prefabs");
            if (!Directory.Exists(prefabsFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(prefabsFilePath);
                directory.Create();
                return "Prefabsフォルダーを作成しました。\n";
            }
            return "Prefabsフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createScriptsFolder(string filePath)
        {
            string scriptsFilePath = (filePath + "/Scripts");
            if (!Directory.Exists(scriptsFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(scriptsFilePath);
                directory.Create();
                return "Scriptsフォルダーを作成しました。\n";
            }
            return "Scriptsフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createAnimationsFolder(string filePath)
        {
            string animationsFilePath = (filePath + "/Animations");
            if (!Directory.Exists(animationsFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(animationsFilePath);
                directory.Create();
                return "Animationsフォルダーを作成しました。\n";
            }
            return "Animationsフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createMaterialsFolder(string filePath)
        {
            string materialsFilePath = (filePath + "/Materials");
            if (!Directory.Exists(materialsFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(materialsFilePath);
                directory.Create();
                return "Materialsフォルダーを作成しました。\n";
            }
            return "Materialsフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createPhysicsMaterialsFolder(string filePath)
        {
            string physicsMaterialsFilePath = (filePath + "/PhysicsMaterials");
            if (!Directory.Exists(physicsMaterialsFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(physicsMaterialsFilePath);
                directory.Create();
                return "PhysicsMaterialsフォルダーを作成しました。\n";
            }
            return "PhysicsMaterialsフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createFontsFolder(string filePath)
        {
            string fontsFilePath = (filePath + "/Fonts");
            if (!Directory.Exists(fontsFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(fontsFilePath);
                directory.Create();
                return "Fontsフォルダーを作成しました。\n";
            }
            return "Fontsフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createTexturesFolder(string filePath)
        {
            string texturesFilePath = (filePath + "/Textures");
            if (!Directory.Exists(texturesFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(texturesFilePath);
                directory.Create();
                return "Texturesフォルダーを作成しました。\n";
            }
            return "Texturesフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createAudioFolder(string filePath)
        {
            string audioFilePath = (filePath + "/Audio");
            if (!Directory.Exists(audioFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(audioFilePath);
                directory.Create();
                return "Audioフォルダーを作成しました。\n";
            }
            return "Audioフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createResourcesFolder(string filePath)
        {
            string resourcesFilePath = (filePath + "/Resources");
            if (!Directory.Exists(resourcesFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(resourcesFilePath);
                directory.Create();
                return "Resourcesフォルダーを作成しました。\n";
            }
            return "Resourcesフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createEditorFolder(string filePath)
        {
            string editorFilePath = (filePath + "/Editor");
            if (!Directory.Exists(editorFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(editorFilePath);
                directory.Create();
                return "Editorフォルダーを作成しました。\n";
            }
            return "Editorフォルダーは存在しているか、作成に失敗しました。\n";
        }

        private string createPluginsFolder(string filePath)
        {
            string pluginsFilePath = (filePath + "/Plugins");
            if (!Directory.Exists(pluginsFilePath))
            {
                DirectoryInfo directory = new DirectoryInfo(pluginsFilePath);
                directory.Create();
                return "Pluginsフォルダーを作成しました。\n";
            }
            return "Pluginsフォルダーは存在しているか、作成に失敗しました。\n";
        }
    }
}