using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWcfService
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드, svc 및 config 파일에서 클래스 이름 "Service1"을 변경할 수 있습니다.
    // 참고: 이 서비스를 테스트하기 위해 WCF 테스트 클라이언트를 시작하려면 솔루션 탐색기에서Service1.svc나 Service1.svc.cs를 선택하고 디버깅을 시작하십시오.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetMax(string value)
        {
            string[] Nums = value.Replace(" ", "").Split(',');
            int max = int.Parse(Nums[0]);

            for (int i = 1; i < Nums.Length; i++)
            {
                int temp = int.Parse(Nums[i]);
                if(temp > max)
                {
                    max = temp;
                }
            }

            return max.ToString();
        }

        public string GetMin(string value)
        {
            string[] Nums = value.Replace(" ", "").Split(',');
            int min = int.Parse(Nums[0]);

            for (int i = 1; i < Nums.Length; i++)
            {
                int temp = int.Parse(Nums[i]);
                if (temp < min)
                {
                    min = temp;
                }
            }

            return min.ToString();
        }

        public string GetSum(string value)
        {
            string[] Nums = value.Replace(" ", "").Split(',');
            int sum = 0;

            for (int i = 0; i < Nums.Length; i++)
            {
                sum += int.Parse(Nums[i]);
                
            }

            return sum.ToString();
        }

        public string GetAvg(string value)
        {
            string[] Nums = value.Replace(" ", "").Split(',');
            
            int avg = int.Parse(GetSum(value)) / Nums.Length;

            return avg.ToString();
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
