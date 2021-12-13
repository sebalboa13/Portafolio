# Generated by Django 3.1.3 on 2021-10-28 06:02

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0011_facturaxxi_tipo_pago'),
    ]

    operations = [
        migrations.CreateModel(
            name='FacturasXxi',
            fields=[
                ('id_factura', models.AutoField(primary_key=True, serialize=False)),
                ('fecha', models.DateField()),
                ('total', models.BigIntegerField()),
                ('nom_proveedor', models.CharField(max_length=100, null=True)),
                ('tipo_pago', models.CharField(max_length=50, null=True)),
                ('media', models.FileField(null=True, upload_to='facturas')),
            ],
        ),
    ]
