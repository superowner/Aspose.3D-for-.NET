﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Aspose._3D.Examples.CSharp.Loading_Saving;
using Aspose._3D.Examples.CSharp.AssetInformation;
using Aspose._3D.Examples.CSharp.Animation;
using Aspose._3D.Examples.CSharp.Rendering;
using Aspose._3D.Examples.CSharp.Geometry_Hierarchy;
using Aspose._3D.Examples.CSharp._3DScene;
using System.Reflection;
using Aspose._3D.Examples.CSharp._3DModeling;
using Aspose._3D.Examples.CSharp._3DViewPorts;
using Aspose._3D.Examples.CSharp._Working_with_Objects;
using Aspose._3D.Examples.CSharp.Polygons;
using Aspose._3D.Examples.CSharp.Working_with_Objects;
using Aspose._3D.Examples.CSharp.Geometry_and_Hierarchy;
using Aspose._3D.Examples.CSharp.Loading_and_Saving;

namespace Aspose._3D.Examples.CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");
            // Uncomment the one you want to try out          

            // =====================================================
            // =====================================================
            // Loading and Saving
            // =====================================================
            // =====================================================

            // CreateEmpty3DDocument.Run();          
            // ReadExistingScene.Run();
            // DetectFormat.Run();
            // Save3DInPdf.Run();
            // OpenSceneFromProtectedPdf.Run();
            // ExtractAll3DScenes.Run();
            // SaveOptions.SavingDependenciesInMemoryFileSystem();
            // LoadOptions.Run();
            // SaveOptions.Run();
            // Non_PBRtoPBRMaterial.Run();

            // =====================================================
            // =====================================================
            // Animation
            // =====================================================
            // =====================================================

            // PropertyToDocument.Run();
            // SetupTargetAndCamera.Run();

            // =====================================================
            // =====================================================
            // 3DScene
            // =====================================================
            // =====================================================

            // FlipCoordinateSystem.Run();
            // Save3DMeshesInCustomBinaryFormat.Run();

            // =====================================================
            // =====================================================
            // Asset Information
            // =====================================================
            // =====================================================

            // InformationToScene.Run();

            // =====================================================
            // =====================================================
            // Geometry and Hierarchy
            // =====================================================

            // CubeScene.Run();
            // MaterialToCube.Run();            
            // TransformationToNodeByQuaternion.Run();
            // TransformationToNodeByEulerAngles.Run();
            // TransformationToNodeByTransformationMatrix.Run();
            // NodeHierarchy.Run();
            // MeshGeometryData.Run();
            // SetupNormalsOnCube.Run();
            // TriangulateMesh.Run();
            // ConcatenateQuaternions.Run();
            // ApplyPBRMaterialToBox.Run();

            //// =====================================================
            //// =====================================================
            //// 3D Modeling
            //// =====================================================
            //// =====================================================

            // Primitive3DModels.Run();

            // =====================================================
            // =====================================================
            // Working with Objects
            // =====================================================
            // =====================================================

            // SplitMeshbyMaterial.Run();            
            // ConvertSpherePrimitivetoMesh.Run();
            // ConvertBoxPrimitivetoMesh.Run();
            // ConvertPlanePrimitivetoMesh.Run();
            // ConvertCylinderPrimitivetoMesh.Run();
            // ConvertTorusPrimitivetoMesh.Run();
            // ConvertSphereMeshtoTriangleMeshCustomMemoryLayout.Run();
            // ConvertBoxMeshtoTriangleMeshCustomMemoryLayout.Run();
            // GenerateDataForMeshes.Run();
            // BuildTangentAndBinormalData.Run();
            // Encode3DMeshinGoogleDraco.Run();

            // =====================================================
            // =====================================================
            // Rendering
            // =====================================================
            // =====================================================
            // RenderSceneIntoCubemapwithsixfaces.Run();
            // RenderPanaromaViewof3DScene.Run();
            // RenderFisheyeLensEffectof3DScene.Run();
            // Render3DModelImageFromCamera.Run();
            // CastAndReceiveShadow.Run();
            RenderSceneWithPanoramaInDepth.Run();

            // =====================================================
            // =====================================================
            // 3DViewPorts
            // =====================================================
            // =====================================================
            // ApplyVisualEffects.Run();
            // CaptureViewPort.Run();

            // =====================================================
            // =====================================================
            // Polygons
            // =====================================================
            // =====================================================
            // ConvertPolygonsToTriangles.Run();

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        public static string GetDataDir()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }
        public static string GetOutputFilePath(String inputFilePath)
        {
            string extension = Path.GetExtension(inputFilePath);
            string filename = Path.GetFileNameWithoutExtension(inputFilePath);
            return filename + "_out" + extension;
        }
    }
}
