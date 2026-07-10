
public class Computer
{
   public string CPU { get; }
   public int RAM { get; }
   public int Storage { get; }
   public bool HasGPU { get; }

   private Computer(Builder builder)
   {
      CPU = builder.CPU;
      RAM = builder.RAM;
      Storage = builder.Storage;
      HasGPU = builder.HasGPU;
   }

   public class Builder
   {
      public string CPU { get; private set; }
      public int RAM { get; private set; }
      public int Storage { get; private set; }
      public bool HasGPU { get; private set; }

      public Builder WithCPU(string cpu)
      {
         CPU = cpu;
         return this;
      }
      public Builder WithRAM(int ram)
      {
         RAM = ram;
         return this;
      }
      public Builder WithStorage(int storage)
      {
         Storage = storage;
         return this;
      }
      public Builder WithGPU(bool gpu)
      {
         HasGPU = true;
         return this;
      }
      public Computer Build()
      {
         return new Computer(this);
      }
   }
}



class Program
{
   static void Main()
   {
      var pc = new Computer.Builder()
                    .WithCPU("Intel")
                    .WithRAM(32)
                    .WithStorage(1000)
                    .WithGPU(true)
                    .Build();
   }
}